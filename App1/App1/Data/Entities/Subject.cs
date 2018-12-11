using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Data.Entities
{
    public class Subject : ISqliteModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
