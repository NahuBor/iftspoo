using System;
using System.Collections.Generic;
namespace mp {
    internal class Program {
        public static void Main(string[] args) {
            List<Integrante> intregrantes = new List<Integrante> {
            new Jugador("Juan", "Goliata", 20, 10, "Cat: 2000"),
            new Jugador("Francis", "De Sabato", 22, 5, "Cat: 1954"),
            new Entrenador("David", "Kant", 30, 3),
            new Entrenador("Chistopher", "Xavi", 33, 4),
            new Administrativo("Danii", "Aliz", 35, "Lic. en Administración", "Project Manager"),
            new Administrativo("Sergito", "Rocky", 45, "Lic. en Economía", "Sales Agent")
        };
        foreach (Integrante i in intregrantes) {
            i.MostrarInfo();
        }
    }
}
}