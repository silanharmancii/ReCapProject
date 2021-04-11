using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class CustomerDetailDto:IDto
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string CompanyName { get; set; }
        public byte[] Password { get; set; }
        public string Email { get; set; }
       
    }
}
