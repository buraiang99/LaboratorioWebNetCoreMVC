using LaboratorioWebNetCoreMVC.Data;
using LaboratorioWebNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioWebNetCoreMVC.Controllers
{
    public class EstudiantesController : Controller
    {

        private EstudianteData _contex;
        private List<Estudiante> estudianreList = new List<Estudiante>();
        public EstudiantesController()
        {
            this.estudianreList = new List<Estudiante>();
        }
        public IActionResult Index()
        {
            this.estudianreList.Add(new Estudiante("B00000", "Pedro", "Ramirez", 21));
            this.estudianreList.Add(new Estudiante("B11111", "Marco", "Jimenez", 21));
            this.estudianreList.Add(new Estudiante("B22222", "Juan", "Brenes", 21));
            this.estudianreList.Add(new Estudiante("B33333", "Pablo", "Mora", 21));
            this.estudianreList.Add(new Estudiante("B44444", "Carlos", "Salas", 21));
            return View(this.estudianreList);
        }
        [HttpGet]
        [Route("controller/accion/{id}")]
        public IActionResult MostrarEstudiantes(string id)
        {
            this.estudianreList.Add(new Estudiante("B00000", "Pedro", "Ramirez", 21));
            this.estudianreList.Add(new Estudiante("B11111", "Marco", "Jimenez", 21));
            this.estudianreList.Add(new Estudiante("B22222", "Juan", "Brenes", 21));
            this.estudianreList.Add(new Estudiante("B33333", "Pablo", "Mora", 21));
            this.estudianreList.Add(new Estudiante("B44444", "Carlos", "Salas", 21));
            //string param = (string)ViewData["carnet"];
            //Console.WriteLine("------------------------"+id);
            foreach (var item in this.estudianreList)
            {
                if (String.Equals(id,item.Carnet))
                {
                    Estudiante estudiante = new Estudiante(item.Carnet,item.Nombre,item.Apellido, item.Edad);
                    
                    return View("Views/Estudiantes/View.cshtml", estudiante);
                }
            }
            Estudiante estudiante2 = new Estudiante(id, "null", "null", 0);
            return View("Views/Estudiantes/View.cshtml", estudiante2);
        }
    }
}
