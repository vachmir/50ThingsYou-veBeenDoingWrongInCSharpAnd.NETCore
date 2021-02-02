using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParallelismAndAsynchronicity.TaskingSignature
{
    class CustumerServise : ICustomerService
    {
        public Task<Customer> GetCustomerDetails(int id)
        {
            return Task.FromResult( new Customer());
        }
    }
}
