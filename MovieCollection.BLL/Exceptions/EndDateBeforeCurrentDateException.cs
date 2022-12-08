using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.BLL.Exceptions
{
    public class EndDateBeforeCurrentDateException : Exception
    {
        public EndDateBeforeCurrentDateException()
        {

        }

        public EndDateBeforeCurrentDateException(DateTime endDate)
            : base($"Enddate {endDate} lies before the current date.")
        {

        }
    }
}
