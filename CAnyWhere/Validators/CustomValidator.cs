using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Validators
{
    internal interface CustomValidator
    {
        Boolean Validate(object value);
    }
}
