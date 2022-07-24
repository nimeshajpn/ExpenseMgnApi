using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Expense;

namespace ExpensemgnApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseRepository _r;

        public ExpenseController(IExpenseRepository r)
        {
            _r = r;
        }

        [HttpGet]
        public IActionResult GetExpense() { 
        
        var v= _r.GetExpense();
            return Ok(v);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int? Id) {

            var v = _r.GetById(Id);

        return Ok(v);
        
        }


    }
}
