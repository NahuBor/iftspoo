public class Ambiente {
    public string sistemaOperativo;
    public int ram;
    public string base_datos;
    public string app;
    public Ambiente (string sistemaOperativo, int ram, string base_datos, string app) {
        this.sistemaOperativo = sistemaOperativo;
        this.ram = ram;
        this.base_datos = base_datos;
        this.app = app;
    }

    public void VerificarDespliegue() {
        
        if (!(this.sistemaOperativo == "linux" & this.ram == 4 & this.base_datos == "postgresql" & this.app == "openjdk")) {
            Console.WriteLine("Despliegue no autorizado.");
        } else {
            Console.WriteLine("Despliegue autorizado.");
        }
    }
}