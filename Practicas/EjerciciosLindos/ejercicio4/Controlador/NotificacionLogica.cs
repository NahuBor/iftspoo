namespace ej4 {
    internal class NotificacionLogica {
        List<Notificacion> notis = new List<Notificacion> {
            new NotificacionInterna("RRHH", "Comienzo de la etapa de efectivación"),
            new EmailNotificacion("nahuel@gmail.com", "Has sido ascendido"),
            new SmsNotificacion("11321234521", "Hola, buenassssss")
        };

        public void EnvioMasivo () {
            Console.WriteLine("Enviando notificaciones masivas...");
            foreach (Notificacion n in notis) {
                n.Enviar();
            }
        }
    }
}