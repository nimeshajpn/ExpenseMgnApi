﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MExpense
    {
        public int Id { get; set; }
        public string Category { get; set; }
       
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }    

        public int IdUser { get; set; }
    }
}
