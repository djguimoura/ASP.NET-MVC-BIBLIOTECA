using K19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Instanciando um objeto do tipo Aluno para visualização na view Aluno:Detalhes(testes)
        public ActionResult Detalhes()
        {
            Aluno a = new Aluno
            {
                AlunoID = 1,
                Nome = "Guilherme",
                Email = "gui@me.com"
            };
            return View(a);
        }
        //Listagem de "Alunos" para visualização na view Aluno:Lista(testes)
        public ActionResult Lista()
        {
            ICollection<Aluno> lista = new List<Aluno>();
            for (int i = 0; i < 5; i++)
            {
                Aluno a = new Aluno
                {
                    AlunoID = i,
                    Nome = "Aluno: " + i,
                    Email = "Email: " + i
                };
                lista.Add(a);
            }

            return View(lista);
        }

        public ActionResult Editar()
        {
            Aluno a = new Aluno
            {
                AlunoID = 1,
                Nome = "Guilherme",
                Email = "gui@me.com"
            };
            return View(a);
        }
    }
}