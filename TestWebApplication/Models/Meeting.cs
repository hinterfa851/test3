using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public int Datatime { get; set; }
  //      public List<string> Users { get; set; }
    }
}