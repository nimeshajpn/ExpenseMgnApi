using DbConnections;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Expense
{
    public class ExpenseService : IExpenseRepository
    {
        private readonly ExpenseMgnContext con = new ExpenseMgnContext();

        public List<MExpense> GetExpense()
        {

            return con.TbExpensies.ToList();

        }

        public MExpense GetById(int? Id)
        {


            return con.TbExpensies.Find(Id);



        }
        public MExpense AddEXpense(MExpense e)
        { 
        con.TbExpensies.Add(e);
        con.SaveChanges();


            return con.TbExpensies.Find(e.Id);
        }
        
        public void UpdateEXpense(MExpense e)
        { 
       
        con.SaveChanges();


       
        }
        public void DeleteExpense(MExpense e)
        {
            con.TbExpensies.Remove(e);
            con.SaveChanges();


            
        }
    }
}
