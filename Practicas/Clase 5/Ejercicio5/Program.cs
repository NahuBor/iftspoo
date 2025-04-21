public class Program {
    public static void Main(string[] args) {
        Ambiente ambiente = new Ambiente("linux",4,"postgresql", "openjdk");
        ambiente.VerificarDespliegue();
        Ambiente ambiente2 = new Ambiente("windows",4,"postgresql", "openjdk");
        ambiente2.VerificarDespliegue();
    }
}

