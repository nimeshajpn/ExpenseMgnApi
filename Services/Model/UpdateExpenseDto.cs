using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class UpdateExpenseDto
    {
        public string Category { get; set; }

        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
    }
}
