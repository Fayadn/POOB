using System;
using System.Globalization;
using Contratos.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Services
{
    class ContractService
    {
        public Contract contract { get; set; }
        public int Months { get; set; }

        public void processContract(Contract contract, int months)
        {
            this.contract = contract;
            Months = months;

        }
    }
}
