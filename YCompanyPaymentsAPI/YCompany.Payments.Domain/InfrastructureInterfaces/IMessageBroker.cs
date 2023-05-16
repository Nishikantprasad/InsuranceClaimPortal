﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCompany.Payments.Domain.InfrastructureInterfaces
{
    public interface IMessageBroker
    {
        Task<bool> CheckHealthAsync();
    }
}