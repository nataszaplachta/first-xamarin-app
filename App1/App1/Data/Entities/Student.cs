using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Data.Entities
{
    public class Student : ISqliteModel
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int ClassNumber { get; set; }
        public DateTime Birthday { get; set; }
    }
}
