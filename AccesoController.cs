using Autenticacion_Roles.Data;
using Autenticacion_Roles.Models;
using Microsoft.AspNetCore.Mvc;

namespace Autenticacion_Roles.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(Usuario u)
        {
            DA_Logica da = new DA_Logica();
            var usuario = da.validarUsuario(u.Correo,u.Clave);
            if (usuario != null) {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
