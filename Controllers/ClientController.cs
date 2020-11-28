using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebComplete.Models;
using System.Data.Entity;

namespace WebComplete.Controllers
{
    public class ClientController : Controller
    {

        ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {

            List<Client>Clientes = _context.Client.Include(c => c.Plan).ToList();

            return View(Clientes);
        }

        public ActionResult New()
        {
            List<Plan> plans = new List<Plan>();
            plans =_
            return View();
        }
    }
}