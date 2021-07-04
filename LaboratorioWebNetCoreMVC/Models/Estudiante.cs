using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioWebNetCoreMVC.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "El carnet es obligatorio")]
        [StringLength(6, ErrorMessage = "El {0} de ser al menos {2} y maximo {1} caracteres", MinimumLength = 6)]
        public string Carnet { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La edad es obligatorio")]
        public int Edad { get; set; }

        public Estudiante(string carnet, string nombre, string apellido, int edad)
        {
            Carnet = carnet;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
    }
}
