using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4ex2
{
    interface Attributes
    {
        bool validate(string entry);
        List<string> getValues();
        void clear();
    }
}
