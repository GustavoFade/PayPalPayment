using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstNmae, string lastName)
        {
            FirstNmae = firstNmae;
            LastName = lastName;
        }

        public string FirstNmae { get; private set; }
        public string LastName { get; private set; }
    }
}