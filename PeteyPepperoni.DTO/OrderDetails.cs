﻿using PeteyPepperoni.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeteyPepperoni.DTO
{
    public class OrderDetails
    {
        public Guid orderID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public PaymentMethodType PaymentMethod { get; set; }
        public SizeType Size { get; set; }
        public CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Mushrooms { get; set; }
        public bool BlackOlives { get; set; }
        public bool GreenOlives { get; set; }
    }
}
