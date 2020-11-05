using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using TestWebApplication.Models;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace TestWebApplication.Controllers
{
    public class ValuesController : ApiController
    {

        meetingsContext db = new meetingsContext();


        // GET api/values

        public IEnumerable<string> Get()
        {
            string res = "";
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';Integrated Security=True";

            SqlConnection connection = new SqlConnection(ConnectionString);
            
            try
            {
                // Открываем подключение
                
                object[] obj;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM USERS";
                command.Connection = connection;
                var reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    obj = new object[reader.VisibleFieldCount];
                    reader.GetValues(obj);
                    foreach (object i in obj)
                    {
                        res += i.ToString();
                        res += ";";
                    }
                    res += "\n";
                }

            }
            catch (SqlException ex)
            {
                return new string[] { ex.Message };

            }
            finally
            {
                // закрываем подключение
                connection.Close();
                
            }
            return new string[] { res };
        }

        /*
        public string Get()
        {
            return JsonConvert.SerializeObject(db.Meetings);
        }

        
        public IEnumerable<Meeting> Get()
        {
            return JsonConvert.SerializeObject(db.Meetings);
        }
        */

        public Meeting GetMeeting(int id)
        {
            Meeting meet = db.Meetings.Find(id);
            return meet;
        }

        // GET api/values/5

        /*public string Get(int id)
        {
            return "value";
        } */

        // POST api/values
        public void CreateMeetng([FromBody] Meeting meeting)
        {
            db.Meetings.Add(meeting);
            db.SaveChanges();
        }

        // PUT api/values/5
        /*public void Put(int id, [FromBody] string value)
        {
        }*/

        // DELETE api/values/5
        public void DeleteMeeting(int id)
        {
            Meeting meeting = db.Meetings.Find(id);
            if(meeting != null)
            {
                db.Meetings.Remove(meeting);
                db.SaveChanges();
            }
        }
    }

   
}


// 