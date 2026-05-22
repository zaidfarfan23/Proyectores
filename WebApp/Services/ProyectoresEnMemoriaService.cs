using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores = LoadData();

        public void AddProyector(Proyector proyector)
        {
            if (proyector != null)
            {
                _proyectores.Add(proyector);
            }
        }

     

        public IEnumerable<Proyector> GetAll()
        {
            return _proyectores;

        }

        private static List<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()


            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now


            });

            proyectores.Add(new Proyector()


            {
                Id = 2,
                Marca = "Sony",
                Modelo = "Permormer",
                NumeroDeSerie = "86583",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now


            });

            proyectores.Add(new Proyector()


            {
                Id = 3,
                Marca = "Epson",
                Modelo = "Nasty",
                NumeroDeSerie = "77789",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now


            });

            proyectores.Add(new Proyector()


            {
                Id = 4,
                Marca = "Sony",
                Modelo = "Goodx",
                NumeroDeSerie = "999123",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now


            });

            proyectores.Add(new Proyector()


            {
                Id = 5,
                Marca = "Action",
                Modelo = "Nice",
                NumeroDeSerie = "44823",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now


            });




            return proyectores;
        }
    }
}
