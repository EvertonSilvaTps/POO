using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotificacoes
{
    public class PushNotification : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            base.Enviar(mensagem);
            Console.WriteLine("Notificação Push enviado!");
        }

    }
}
