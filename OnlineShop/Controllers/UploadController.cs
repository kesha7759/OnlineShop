using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Formatting;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class UploadController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UploadController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ImportXml(IFormFile xmlFile)
        {
            
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/xmls", xmlFile.FileName);
            //создается файл в директории wwwroot/xmls
            using (FileStream SourceStream = System.IO.File.Open(path, FileMode.OpenOrCreate))
            {
                //считывается файл из буфера в только что созданный файл
                await xmlFile.CopyToAsync(SourceStream);
            }
            ProcessImport(path);
            return View("Index");
        }
        //метод для считывания из созданного xml файла в директории wwwroot/xmls
        private async Task ProcessImport(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Good>), new XmlRootAttribute("Goods"));
            using (FileStream stream = System.IO.File.Open(path, FileMode.Open))
            {
                List<Good> newGood = (List<Good>)formatter.Deserialize(stream);
                foreach (Good g in newGood)
                {
                    _context.Goods.Add(g);
                }
                _context.SaveChanges();
            }
            
        }
    }
}
