using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine
{
    interface IRules
    {
           float Run(customer cust); 
    }

    public class customer { };

    public class LongTermDiscount : IRules
    {
        public float Run(customer cust)
        {
            return 10.0f;
        }
    }

    public class BirthdayDiscount : IRules
    {
        public float Run(customer cust)
        {
            return 20.0f;
        }
    }

    public class LastPurchaseDiscount : IRules
    {
        public float Run(customer cust)
        {
            return 15.0f;
        }
    }

        
}
