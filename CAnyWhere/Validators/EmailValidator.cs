using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Validators
{
    internal class EmailValidator : CustomValidator
    {
        public bool Validate(object value)
        {
            return new EmailAddressAttribute().IsValid(value);
        }
    }
}
