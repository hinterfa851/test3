using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace TestWebApplication.Models
{
        public class meetingsContext : DbContext
        {
  //      public meetingsContext(string connectionString) : base( connectionString)
    //    { }
        public DbSet<Meeting> Meetings { get; set; }
        }

    
}
//INSERT INTO Meeting (Namee, Creator, Datetim) VALUES('jefk', 'fewf', '12-01-16 12:32')
// CREATE TABLE Meetings(ID int IDENTITY(1,1), Namee char(255) NOT NULL, Creator char(255) NOT NULL, Datetim datetime NOT NULL, PRIMARY KEY (ID))