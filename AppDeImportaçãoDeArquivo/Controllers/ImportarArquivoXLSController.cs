using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDeImportaçãoDeArquivo.Controllers
{
    public class ImportarArquivoXLSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ImportarArquivoXLS()
        {
            return View();
        }
    }
}
