using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IExpenseRepository
    {
        public List<MExpense> GetExpense();
        public MExpense GetById(int? Id);
    }
}
