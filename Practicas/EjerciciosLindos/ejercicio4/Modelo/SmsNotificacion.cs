namespace ej4 {
    internal class SmsNotificacion : Notificacion {
        public SmsNotificacion (string destinatario, string mensaje) : base (destinatario, mensaje){}

        public override void Enviar() {
            Console.WriteLine($"Enviando SMS a {GetDestinatario()} con el mensaje: {GetMensaje()}");
        }
    }
}