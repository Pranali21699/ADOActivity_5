using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOActivity_5DAL
{
    public class act5
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;

        public string ConnectToDB()
        {
            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["abc"].ToString());
                //string conStr = ConfigurationManager.ConnectionStrings["AdvConStr"].ToString();
                sqlConObj.Open();
                return sqlConObj.State.ToString();
            }
            catch (Exception)
            {
                return sqlConObj.State.ToString();

            }
            finally
            {
                sqlConObj.Close();
            }

        }
        public string GetFullName(int inputID)
        {
            string result = String.Empty;
           sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["abc"].ToString());
            //sqlCmdObj = new SqlCommand(@"SELECT [dbo].[ufnGetFullName]("+id+")", sqlConObj);
            sqlCmdObj = new SqlCommand(@"SELECT [dbo].[ufnGetFullName](@ID)", sqlConObj);
            sqlCmdObj.Parameters.AddWithValue("@ID", inputID);
            //sqlCmdObj.Parameters.Add()
            try
            {
                sqlConObj.Open();
                result = Convert.ToString(sqlCmdObj.ExecuteScalar());
                return result;
            }
            catch (Exception ex)
            {
                result = "Error occurred";
                return result;
                //throw;
            }
        }
    }
}
