using CadeMeuMedico.Data;
using CadeMeuMedico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CadeMeuMedico.Controllers
{
    public class MedicosController : Controller
    {
        private readonly MedicosContext _context;

        public MedicosController(MedicosContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //var medicos = db.Medico.Include(m => m.FKCidade).Include(m => m.FKEspecialidade).ToList();
            return View(await _context.Medico.Include(s => s.FKCidade).Include(s => s.FKEspecialidade).ToListAsync());
        }

        public ActionResult Adicionar()
        {

            ViewBag.FKCidade = new SelectList(_context.Cidade, "IDCidade", "Nome");
            ViewBag.FKEspecialidade = new SelectList(_context.Especialidade, "IDEspecialidade", "Nome");

            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(MedicoModel medico,int FKCidade, int FKEspecialidade)
        {

            CidadeModel cidade = _context.Cidade.Find(FKCidade);
            EspecialidadeModel especialidade = _context.Especialidade.Find(FKEspecialidade);
            medico.FKCidade = cidade;
            medico.FKEspecialidade= especialidade;

            if (ModelState.IsValid)
                {
                    _context.Add(medico);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

            /*ViewBag.FKCidade = new SelectList(_context.Cidade, "FKCidade", "Nome", medico.FKCidade);
            ViewBag.FKEspecialidade = new SelectList(_context.Especialidade, "FKEspecialidade", "Nome", medico.FKEspecialidade);*/
            
            

            return View(medico);

        }
        [HttpPost]
        public string Excluir(int id)
        {
            try
            {

                MedicoModel medico = _context.Medico.Find(id);
                

                _context.Remove(medico);
                _context.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }

        public ActionResult Edit(int id)
        {

            

            ViewBag.FKCidade = new SelectList(_context.Cidade, "IDCidade", "Nome");
            ViewBag.FKEspecialidade = new SelectList(_context.Especialidade, "IDEspecialidade", "Nome");



            return View(_context.Medico.Include(s => s.FKCidade).Include(s => s.FKEspecialidade).FirstOrDefault(x => x.IDMedico == id));

        }

        [HttpPost]
        public ActionResult Edit(MedicoModel medico, int FKCidade, int FKEspecialidade)
        {
            CidadeModel cidade = _context.Cidade.Find(FKCidade);
            EspecialidadeModel especialidade = _context.Especialidade.Find(FKEspecialidade);
            medico.FKCidade = cidade;
            medico.FKEspecialidade = especialidade;
            

            if (ModelState.IsValid)
            {
                _context.Medico.Update(medico);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medico);

        }

    }
    //aaaaaa
}
