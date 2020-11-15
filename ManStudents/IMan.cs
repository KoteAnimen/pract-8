using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManStudents
{
    interface IMan
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }

        string GetParams();

    }
}
