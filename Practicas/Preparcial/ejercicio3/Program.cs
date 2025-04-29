public class Program {
    public static void Main(string[] args) {
        Jugador jugador1 = new Jugador("nahuelito", 25, 2, "defensor");
        jugador1.SumarAntiguedad(1); // Camino exitoso, cant establecidad por parametro menor a los años de antiguedad.
        jugador1.MostrarInformacion();

        Jugador jugador2 = new Jugador("narnia", 30, 8, "delantero");
        jugador2.SumarAntiguedad(5, "Actualización de datos");
        jugador2.MostrarInformacion();

        Tecnico tecnico1 = new Tecnico("don osvaldo", 20, 2, "Soporte tecnico");
        tecnico1.SumarAntiguedad(3); // Caso erroneo, cant establecidad por parametro mayor a los años de antiguedad.
        tecnico1.MostrarInformacion();

        Tecnico tecnico2 = new Tecnico("susana", 60, 30, "Soporte tecnico");
        tecnico2.SumarAntiguedad(10, "Actualización de datos");
        tecnico2.MostrarInformacion();       
        


    }
}
