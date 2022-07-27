using AutoMapper;
using Model;
using Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Profiles
{
    public class ExpenceProfile : Profile
    {
        public ExpenceProfile()
        {
            CreateMap<MExpense, MExpenseDto>();
            CreateMap<CreateExpenseDto, MExpense>();
            CreateMap<UpdateExpenseDto, MExpense>();
        }
    }
}
