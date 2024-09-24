using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataMaintenance.DAL.U8services
{
    class Rdrecord32Service
    {



        public static string MySqlScript = @"with cte_dispatch_01 as 
(select 
	u.cCCCode as 客户类别编码 , 
	u.cCCName as 客户类别名称, 
	f.cCusCode as 客户编码, 
	c.cCusName as 客户名称, 
	--c.cCusEnName,--启用出口模块才有用
	e.ccdefine1 as CusEngName,
	f.cDLCode  as 发货单号 ,
	fs.cinvcode 存货编码 ,
	fs.inatUnitPrice  as 本币销售无税单价
 from  UFDATA_017_2017..DispatchList f --发货单主表
	inner join UFDATA_017_2017..DispatchLists fs --发货单子表
		on f.DLID  =fs.dlid
	inner join UFDATA_017_2017 ..customer c --客户档案
		on f.cCusCode =c.cCusCode
	inner join UFDATA_017_2017..Customer_extradefine as e --客户档案扩展自定义项
		on c.cCusCode=e.cCusCode
	inner join UFDATA_017_2017 ..CustomerClass as u --客户类别表
		on c.cCCCode =u.cCCCode 
where f.dDate >'2023-01-01' and c.cCusCode='0215'
),
--1.2发货单分组排行（因同一发货单上有相同的单品）
cte_dispatch_02 as 
(
select  row_number() over(partition  by 发货单号,存货编码 order by 发货单号,存货编码 desc) as 行号,*
from cte_dispatch_01 
),
--1.3取行号为1的发货单
cte_dispatch_03 as 
(select  *
from cte_dispatch_02
where 行号 =1

),
--2.*****************************************************************销售出库单明细**********************************************
cte_rdrecord32 as 
(
select  
		--p.cBusCode as 发货单号 ,--BUG,如果多张发货单生成一张出库单时，主表表头的发货单号只体现出第一张发发货单号
		ps.cbdlcode as 发货单号,--取子表中的发货单号,20190508
		 p.ddate 出库日期,  
		p.cCode 出库单号码,
		ps.cinvcode 存货编码 ,  
		ps.iQuantity  出库数量 
		,isnull(ps.fsettleqty,0) as 已开票数量 ,
		ps.cDefine23  as 形式发票号
 from UFDATA_017_2017..rdrecord32 p --销售出库单主表
		inner join UFDATA_017_2017..rdrecords32  ps --销售出库单子表
			on p.id  =ps.id 
 --where p.cCusCode ='043'
)
--3.*******************************************************************出库与发货合并*******************************************
--  3.1本期出库未开票金额
  select f.客户类别编码 ,
		  f.客户类别名称 , 
		  f.客户编码,
		  f.客户名称,
		  f.CusEngName,
		   p.发货单号 ,
		p.出库日期,   
		p.出库单号码,
		p.存货编码 ,
		i.cInvName 存货名称 ,
		i.cInvStd as 规格型号,
		p.出库数量 , 
		f.本币销售无税单价  ,
		isnull(i.cInvDefine14,0) as 预算价格,
		isnull(e.cidefine1,0) as 额定材料成本, 
		p.已开票数量, p.形式发票号 ,
		p.出库数量 -p.已开票数量 as  未开票数量,
		f.本币销售无税单价 *(p.出库数量 -p.已开票数量) as 未开票金额

from cte_rdrecord32 p --出库单
	inner join cte_dispatch_03  f --发货单
		on p.发货单号  =f.发货单号  and p.存货编码  =f.存货编码   --发货单号与存货编码关联
	inner join UFDATA_017_2017..inventory i --存货档案表
		on p.存货编码 =i.cinvcode 
		left join ufdata_017_2017..Inventory_extradefine as e
			on i.cInvCode=e.cInvCode 
		left join UFDATA_017_2017..ComputationUnit u --计量单位表
			on i.cComUnitCode  =u.cComunitCode

        ";
    }




}

