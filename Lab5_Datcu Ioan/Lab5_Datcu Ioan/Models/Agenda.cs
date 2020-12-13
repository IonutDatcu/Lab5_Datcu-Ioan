using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace Lab5_DatcuIoan.Models
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
