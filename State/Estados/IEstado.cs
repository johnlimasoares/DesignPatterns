﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Estados
{
    public interface IEstado
    {
        void AplicarDescontoExtra(Orcamento orcamento);

        void Aprovar(Orcamento orcamento);
        void Reprovar(Orcamento orcamento);
        void Finalizar(Orcamento orcamento);
        
    }
}
