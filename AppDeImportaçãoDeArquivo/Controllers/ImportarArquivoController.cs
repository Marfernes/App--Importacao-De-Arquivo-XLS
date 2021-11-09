using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDeImportaçãoDeArquivo.Controllers
{
    public class ImportarArquivoController : Controller
    {
        // GET: ImportarArquivoController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ImportarArquivoXLS()
        {
            return View();
        }
        // POST: ImportarArquivoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
