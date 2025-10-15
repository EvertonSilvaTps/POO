using SistemaDeNotificacoes;

Notificacao[] notificacoes = new Notificacao[3];

notificacoes[0] = new SMS();
notificacoes[1] = new Email();
notificacoes[2] = new PushNotification();

foreach (var notificacao in notificacoes)
{
    notificacao.Enviar("Olá, esta é uma notificação importante!");
}