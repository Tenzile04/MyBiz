using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.CustomExceptions.SliderExceptions
{
    public class InvalidNullReferanceException : Exception
    {
        public string PropertyName { get; set; }
        public InvalidNullReferanceException(string propertyName, string message) : base(message)
        {
            PropertyName = propertyName;
        }
    }
}
