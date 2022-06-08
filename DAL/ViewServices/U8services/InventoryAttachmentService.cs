using DataMaintenance.Model.U8;
using DataMaintenance.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Utility.DAL;
using Utility.Sql;

namespace DataMaintenance.DAL.ViewServices.U8services
{
    public class InventoryAttachmentService
    {
        /// <summary>
        /// it is effect,but not efficiency
        /// </summary>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public List<ArchiveVModel> GetInventoryArchive(List<SqlParameter> sqlParameters)

        {
            var q = QueryService.GetDataList<Attachfile>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8);



            var q1 = QueryService.GetDataList<Inventory>(Utility.Sql.Sqlhelper.DataSourceType.u8);

            var q3 = from s in q
                     join c in q1 on s.cInvCode equals c.cInvCode
                     select new
                     {
                         cInvCode = c.cInvCode,
                         archiveMarsterName = c.cInvName,
                         archiveName = s.cFileName,
                         s.AttachFileGUID
                     };



            List<ArchiveVModel> ls = new List<ArchiveVModel>();

            foreach (var item in q3)
            {
                ArchiveVModel m = new ArchiveVModel();
                m.ArchiveCode = item.cInvCode;
                m.ArchiveMarsterName = item.archiveMarsterName;
                m.ArchiveName = item.archiveName;
                m.AttachFileGUID = item.AttachFileGUID;

                ls.Add(m);
            }

            return ls;


        }

        public List<ArchiveVModel> GetInventoryArchive(SqlParameter[] sqlParameter)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"select * from inventory as a ");
            sb.Append($" inner join Attachfile as b  on a.cinvcode=b.cinvcode where b.ctablename=@ctablename and b.cinvcode=@cinvcode ");

          

           SqlDataReader reader= Sqlhelper.GetSqlDataReader(sb.ToString(), sqlParameter, Sqlhelper.DataSourceType.u8);

            List<ArchiveVModel> ls = new List<ArchiveVModel>();

            while (reader.Read())
            {
                ArchiveVModel m = new ArchiveVModel();
                m.ArchiveCode = reader["cInvCode"].ToString();
                m.ArchiveMarsterName = reader["cInvname"].ToString();
                m.ArchiveName = reader["cFileName"].ToString();
                m.AttachFileGUID =(Guid)reader["AttachFileGUID"];
            

                ls.Add(m);
            }
           
            return ls;

        }
    }
}
