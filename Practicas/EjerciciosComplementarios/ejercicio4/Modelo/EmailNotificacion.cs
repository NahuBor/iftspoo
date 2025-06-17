namespace ej4{
    internal class EmailNotificacion : Notificacion {
        public EmailNotificacion (string destinatario, string mensaje) : base (mensaje, destinatario ) {}
        public override void  Enviar () {
            Console.WriteLine($"Enviando email a {GetDestinatario()} con el mensaje: {GetMensaje()}");
        }
    }
}