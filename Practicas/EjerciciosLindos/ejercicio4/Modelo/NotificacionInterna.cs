namespace ej4 {
    internal class NotificacionInterna : Notificacion {
        public NotificacionInterna (string destinatario, string mensaje) : base (destinatario, mensaje){}

        public override void Enviar() {
            Console.WriteLine($"Notificación interna enviada a {GetDestinatario()}, con el mensaje: {GetMensaje()}");
        }
    }
}