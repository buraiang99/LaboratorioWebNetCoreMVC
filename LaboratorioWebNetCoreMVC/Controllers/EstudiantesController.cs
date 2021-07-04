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
        [HttpPost]
        //[Route("nuevadireccion/accion/{carnet}")]
        public IActionResult MostrarEstudiantes(string carnet)
        {
            //string param = (string)ViewData["carnet"];
            Console.WriteLine("------------------------"+carnet);
            foreach (var item in this.estudianreList)
            {
                if (item.Carnet.Equals(carnet))
                {
                    Estudiante estudiante = new Estudiante(item.Carnet,item.Nombre,item.Apellido, item.Edad);
                    
                    return View("Views/Estudiantes/View.cshtml", estudiante);
                }
            }
            Estudiante estudiante2 = new Estudiante("null", "null", "null", 0);
            return View("Views/Estudiantes/View.cshtml", estudiante2);
        }
    }
}
