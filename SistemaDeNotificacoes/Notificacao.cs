using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotificacoes
{
    public abstract class Notificacao
    {
        public string Destinatario;


        public abstract void Enviar();




    }
}
