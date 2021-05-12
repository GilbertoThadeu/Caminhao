using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caminhao.Models;
using Microsoft.Extensions.Logging;

namespace Caminhao.Controllers
{
    //[ApiController]
    //[Route("Caminhao/[controller]")]
    public class CaminhaoController : Controller
    {
        protected DataContext _context;

        public CaminhaoController(DataContext context)
        {
            _context = context;
        }

        //private readonly ILogger<CaminhaoController> _logger;

        //public CaminhaoController(ILogger<CaminhaoController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View(_context.Caminhao.AsQueryable());
        }

        // GET: Caminhao/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Caminhao tB_Caminhao)
        {
            if (ModelState.IsValid)
            {
                if (tB_Caminhao.AnoModelo != DateTime.Now.Year && tB_Caminhao.AnoModelo != DateTime.Now.Year + 1)
                {
                    tB_Caminhao.AnoModelo = 0;
                    tB_Caminhao.Erro = "Ano Modelo tem que ser igual ao ano atual ou subsequente";
                    return View(tB_Caminhao);
                }
                if (tB_Caminhao.AnoFabricacao != DateTime.Now.Year)
                {
                    tB_Caminhao.AnoFabricacao = 0;
                    tB_Caminhao.Erro = "Ano Fabricação tem que ser igual ao ano atual";
                    return View(tB_Caminhao);
                }
                if (tB_Caminhao.Modelo != "FH" && tB_Caminhao.Modelo != "FM")
                {
                    tB_Caminhao.Modelo = "";
                    tB_Caminhao.Erro = @"Modelo tem que ser ""FH"" ou ""FM""";
                    return View(tB_Caminhao);
                }
                _context.Caminhao.Add(tB_Caminhao);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_Caminhao);
        }

        // GET: Caminhao/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Caminhao.Models.Caminhao tB_Caminhao = _context.Caminhao.Find(id);
            if (tB_Caminhao == null)
            {
                return new NotFoundResult();
            }
            return View(tB_Caminhao);
        }

        // GET: Caminhao/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Caminhao.Models.Caminhao tB_Caminhao = _context.Caminhao.Find(id);
            if (tB_Caminhao == null)
            {
                return new NotFoundResult();
            }
            return View(tB_Caminhao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Caminhao tB_Caminhao)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(tB_Caminhao).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_Caminhao);
        }

        // GET: Caminhao/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Caminhao.Models.Caminhao tB_Caminhao = _context.Caminhao.Find(id);
            if (tB_Caminhao == null)
            {
                return new NotFoundResult();
            }
            return View(tB_Caminhao);
        }

        // POST: Caminhao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Caminhao.Models.Caminhao tB_Caminhao = _context.Caminhao.Find(id);
            _context.Caminhao.Remove(tB_Caminhao);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Save(Caminhao.Models.Caminhao caminhao)
        {
            if (caminhao != null)
            {
                _context.Add(caminhao);
                _context.SaveChanges();
                return Created("/Caminhao/" + caminhao.Id, caminhao);
            }

            return BadRequest();
        }

        //[EnableQuery]
        //public IQueryable<Caminhao.Models.Caminhao> Get()
        //{
        //    return _context.Caminhao.AsQueryable();
        //}
    }
}
