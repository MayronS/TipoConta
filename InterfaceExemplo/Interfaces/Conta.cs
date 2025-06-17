using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IConta
    {
        string nome { get; set; }
        string cpf { get; set; }
        double valor { get; set; }

        void saldoFinal();
    }

}