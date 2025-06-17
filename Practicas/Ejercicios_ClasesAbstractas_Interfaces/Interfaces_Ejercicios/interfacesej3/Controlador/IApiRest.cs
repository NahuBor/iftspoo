namespace Interfacesej3 {
    public interface IApiRest {
        public  void Get(int id);
        public  void Post(string nuevo);
        public  void Put(int id, string cambio);
        public  void Delete(int id);
    }
}