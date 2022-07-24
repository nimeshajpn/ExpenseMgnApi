using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnections
{
    public class ExpenseMgnContext:DbContext
    {

        public DbSet<MExpense> TbExpensies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var con = "Server=DESKTOP-8LSRCMK;Database=Expenmgn; Integrated Security=True";
            optionsBuilder.UseSqlServer(con);
        }
    }
}
