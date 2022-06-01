﻿using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.DAL;
using static Utility.Sql.Sqlhelper;

namespace DataMaintenance.DAL.U8services.TableServices
{
  public  class AttacheFileService
    {
        public List<Attachfile> GetListAttachfile()
        {
            return Utility.DAL.QueryService.GetDataList<Attachfile>(DataSourceType.u8);
        }

        /// <summary>
        /// get distince customer in attachfile
        /// </summary>
        /// <returns></returns>
        public List<string> GetListCustomerInAttachfiles()
        {
             return QueryService.GetDataList<Attachfile>(DataSourceType.u8).Where(s => s.cTableName== "Customer").Select(x =>x.cInvCode).Distinct().ToList();
           
        }


        /// <summary>
        /// get distince inventory in attachfile
        /// </summary>
        /// <returns></returns>
        public List<string> GetListInventoryInAttachfiles()
        {
            return QueryService.GetDataList<Attachfile>(DataSourceType.u8).Where(s => s.cTableName== "Inventory").Select(x => x.cInvCode).Distinct().ToList();

        }
    }
}
