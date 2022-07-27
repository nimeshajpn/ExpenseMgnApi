using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services.Expense;
using Services.Model;

namespace ExpensemgnApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseRepository _r;
        private readonly IMapper _m;
        public ExpenseController(IExpenseRepository r, IMapper m)
        {
            _r = r;
            _m = m;
        }

        [HttpGet]
        public IActionResult GetExpense()
        {

            var v = _r.GetExpense();
            return Ok(v);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int? Id)
        {

            var v = _r.GetById(Id);

            return Ok(v);

        }

        [HttpPost]
        public ActionResult<MExpenseDto> Create(CreateExpenseDto a)
        {

            var en = _m.Map<MExpense>(a);
            var newExpense = _r.AddEXpense(en);
            var ExpenseR = _m.Map<MExpenseDto>(newExpense);
            return Ok(ExpenseR);
        }

        [HttpPut("{Id}")]
        public ActionResult Update(int Id,UpdateExpenseDto e)
        {
            var en = _r.GetById(Id);

            _m.Map(e, en);
            _r.UpdateEXpense(en);

            return NoContent();
        } 
        
        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {
            var en = _r.GetById(Id);

            _r.DeleteExpense(en);

            return NoContent();
        }

    }
}
