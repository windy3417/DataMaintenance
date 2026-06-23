using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewServices.U8services
{
    public class NewestPriceJustService
    {
        private readonly string connectionString =Utility.Encrypt.Encrypt.Decode( System.Configuration.ConfigurationManager.
            ConnectionStrings["u8026"].ConnectionString);

        public List<NewestPriceJustModel> GetNewestPriceJustifications()
        {
            var result = new List<NewestPriceJustModel>();

            string query = @"
                WITH cte_PriceJust AS
                (
                    SELECT
                        b.cinvcode,
                        b.iUnitPrice,
                        ROW_NUMBER() OVER (PARTITION BY b.cinvcode ORDER BY a.ddate DESC) AS 行号
                    FROM PU_PriceJustMain AS a
                    INNER JOIN PU_PriceJustDetail AS b
                    ON a.id = b.id
                )
                SELECT cinvcode, iUnitPrice FROM cte_PriceJust WHERE 行号 = 1;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var model = new NewestPriceJustModel
                    {
                        CinvCode = reader["cinvcode"].ToString(),
                        IUnitPrice = Convert.ToDecimal(reader["iUnitPrice"])
                    };
                    result.Add(model);
                }
            }

            return result;
        }
    }

    public class NewestPriceJustModel
    {
        public string CinvCode { get; set; }
        public decimal IUnitPrice { get; set; }
    }
}