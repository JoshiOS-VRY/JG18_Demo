﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace JasperGreen18.Models
{
    public class ServiceViewModel
    {
        public ProvideService CurrentService { get; set; }
        public List<Customer> Customers { get; set; }
        public Customer CurrentCustomer { get; set; }

        public List<Property> Properties { get; set; }
        public Property CurrentProperty { get; set; }

        public List<Crew> Crews { get; set; }
        public Crew CurrentCrew { get; set; }

        public Payment CurrentPayment { get; set; }
        public string Action { get; set; }

        public decimal ServiceFee { get; set; }
    }
}
