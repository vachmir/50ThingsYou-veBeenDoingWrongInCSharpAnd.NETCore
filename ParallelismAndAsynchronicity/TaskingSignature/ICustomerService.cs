using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParallelismAndAsynchronicity.TaskingSignature
{
    interface ICustomerService
    {
        Task<Customer> GetCustomerDetails(int id);
    }
}
