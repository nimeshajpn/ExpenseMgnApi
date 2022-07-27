using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Expense
{
    public interface IExpenseRepository
    {
        public List<MExpense> GetExpense();
        public MExpense GetById(int? Id);
        public MExpense AddEXpense(MExpense e);
        public void UpdateEXpense(MExpense e);
        public void DeleteExpense(MExpense e);
    }
}
