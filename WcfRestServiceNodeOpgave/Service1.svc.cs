using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestServiceNodeOpgave
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private const string ConnectionString = 
            "Server=tcp:myservereasj.database.windows.net,1433;Initial " +
            "Catalog=mydatabase;Persist Security Info=False;User ID=Serveradmin;" +
            "Password=Test12345;MultipleActiveResultSets=False;Encrypt=True;" +
            "TrustServerCertificate=False;Connection Timeout=30;";

        public List<Feedback> GetAll()
        {
            //listen der skal vises i browseren
            List<Feedback> OList = new List<Feedback>();

            const string sqlstring = "SELECT * FROM dbo.WcfRestServiceNodeOpgaveTable where id?@id";

            using (var DBconnection = new SqlConnection(ConnectionString))
            {
                DBconnection.Open();
                var sqlcommand = new SqlCommand(sqlstring, DBconnection);

                using (SqlDataReader reader = sqlcommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Feedback feedback = new Feedback();
                        feedback.id = reader.GetInt32(0);
                        feedback.title = reader.GetString(1).Trim();
                        feedback.message = reader.GetString(2).Trim();
                        feedback.name = reader.GetString(3).Trim();    //trim fjerne whitespaces. 

                        OList.Add(feedback);
                    }
                }
                return OList;
            }
        }

        
    }
}
