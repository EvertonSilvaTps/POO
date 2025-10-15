using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotificacoes
{
    public class Email : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            base.Enviar(mensagem);
            Console.WriteLine($"Email enviado!");
        }
    }
}
