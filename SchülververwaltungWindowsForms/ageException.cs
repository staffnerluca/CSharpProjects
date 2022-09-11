using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeitsprojektForms
{
    class ageException: Exception
    {
        public ageException() { }
        public ageException(string message): base(message) { }
    }
}
