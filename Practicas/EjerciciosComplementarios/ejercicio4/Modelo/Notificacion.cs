namespace ej4 {
    internal abstract class Notificacion {
        private string mensaje;
        private string destinatario;

        public Notificacion (string destinatario, string mensaje) {
            this.mensaje = mensaje;
            this.destinatario = destinatario;
        }

        public string GetMensaje () {
            return mensaje;
        }

        public string GetDestinatario () {
            return destinatario;
        }

        public abstract void Enviar (); 
    }
}