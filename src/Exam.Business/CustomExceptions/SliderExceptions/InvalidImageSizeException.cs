using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.CustomExceptions.SliderExceptions
{
    public class InvalidImageSizeException : Exception
    {
        public string PropertyName { get; set; }
        public InvalidImageSizeException(string propertyName, string message) : base(message)
        {
            PropertyName = propertyName;
        }
    }
}
