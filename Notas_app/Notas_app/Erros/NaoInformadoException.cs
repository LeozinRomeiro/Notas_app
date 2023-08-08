using Notas_app.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notas_app.Erros
{
    internal class NaoInformadoException:Exception
    {
        public NaoInformadoException(string campo)
        { 
        }
    }
}
