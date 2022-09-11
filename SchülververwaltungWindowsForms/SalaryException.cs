using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeitsprojektForms
{
    class SalaryException: Exception
    {
        public SalaryException() { }
        public SalaryException(string message): base(message) { }
    }
}
