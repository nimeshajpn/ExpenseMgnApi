using DbConnections;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ExpenseService : IExpenseRepository
    {
        private readonly ExpenseMgnContext con = new ExpenseMgnContext();

        public List<MExpense> GetExpense()
        {

            return con.TbExpensies.ToList();
        
        }

        public MExpense GetById(int? Id) {


            return con.TbExpensies.Find(Id);
        
        
        
        }
    }
}
