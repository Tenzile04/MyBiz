using Exam.Core.Models;
using Exam.Core.Repositories.Interfaces;
using Exam.Data.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Repositories
{
    public class SliderRepository : GenericRepository<Slider>, ISliderRepository
    {
        public SliderRepository(AppDbContext context) : base(context)
        {
        }
    
    }
}
