using EPlayers_MVC.Interfaces;
using EPlayers_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_MVC_Controller.Controllers
{
    public class NoticiaController : Controller
    {
        Noticia noticiaModel = new Noticia();

        // listar minhas equipes
        [Route("Listar")]
            public IActionResult Index(){
                ViewBag.Noticias = noticiaModel.ReadAll();

                return View();
            }

          
    }
}