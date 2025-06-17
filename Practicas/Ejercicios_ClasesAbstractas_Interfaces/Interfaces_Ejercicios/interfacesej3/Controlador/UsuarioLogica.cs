

namespace Interfacesej3 {
    public class UsuarioLogica : IApiRest {
        public Usuario usuario = new Usuario();

        public UsuarioLogica () {}
        public void Put(int id, string nuevo) {
            if (int.TryParse(nuevo, out int num)) {
                usuario.edad = num;
            } else {
                usuario.nombre = nuevo;
            }
        }

        public void Post(string data) {
            usuario = new Usuario();
            string campoARellenar = "";
            int cantidad = 0;
            bool signal = false;

            foreach (char c in data) {
                if (c == '`') {
                    if (signal) {
                        switch (cantidad) {
                            case 0:
                                usuario.id = int.Parse(campoARellenar);
                                campoARellenar = "";
                                break;
                            case 1:
                                usuario.nombre = campoARellenar;
                                campoARellenar = "";
                                break;
                            case 2:
                                usuario.apellido = campoARellenar;
                                campoARellenar = "";
                                break;
                            case 3:
                                usuario.mail = campoARellenar;
                                campoARellenar = "";
                                break;
                            case 4:
                                usuario.edad = int.Parse(campoARellenar);
                                campoARellenar = "";
                                break;
                        }
                        cantidad++;
                        campoARellenar = "";
                    }
                    signal = !signal;
                } else {
                    if (signal) {
                        campoARellenar += c;
                    }
                }
            }

            Console.WriteLine("Post realizado. Nuevo registro agregado.");
        }

        public void Get(int id) {
            if (usuario.id != id) {
                Console.WriteLine("No se encontro el registro.");
            } else {
            Console.WriteLine($"Ha consultado el registro del usuario con id #{id}: Nombre: {usuario.nombre}, Apellido: {usuario.apellido}, Email: {usuario.mail}, Edad: {usuario.edad}");

            }
        }

        public void Delete(int id) {
            usuario.id = -1;
            Console.WriteLine("Registro eliminado.");
        }
    }
}