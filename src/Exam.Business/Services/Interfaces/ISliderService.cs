using Exam.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Services.Interfaces
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAllAsync();
        Task<Slider> GetAsync(int id);
        Task CreatAsync(Slider slider);
        Task DeleteAsync(int id);       
        Task UpdateAsync(Slider slider);
       
    }
}
