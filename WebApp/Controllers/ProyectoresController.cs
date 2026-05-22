using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()
        {
            return Content(
                "<h1>Aqui se mostrara la lista de proyectores registrados</h1>",
                "text/html"
            );
        }

        public IActionResult Details(int id)
        {
            return Content(
                "<h1>Nuevo Proyector</h1>" +
                "<p>Aqui se mostrara la informacion de un proyector especifico\n"  + id + "</p>" ,
                "text/html"
            );
        }

        public IActionResult Delete(int id)
        {
            return Content(
                "<h1>Dar de baja</h1>" +
                "<p>Aqui se dara de baja el proyector especifico #\n" + id + "</p>",
                "text/html"
            );
        }

        public IActionResult Edit(int id)
        {
            return Content(
                "<h1>Editar Proyector</h1>" +
                "<p>Aqui se modificara la informacion del proyector #\n" + id + "</p>",
                "text/html" 
            );
        }



       

    }
}