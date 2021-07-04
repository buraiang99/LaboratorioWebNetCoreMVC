using LaboratorioWebNetCoreMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioWebNetCoreMVC.Data
{
    public class EstudianteData
    {
        private ArrayList arrayListEstudiantes;
        public EstudianteData()
        {
            this.arrayListEstudiantes = new ArrayList();
            this.arrayListEstudiantes.Add(new Estudiante("B00000","Pedro","Ramirez",21));
            this.arrayListEstudiantes.Add(new Estudiante("B11111", "Marco", "Jimenez", 21));
            this.arrayListEstudiantes.Add(new Estudiante("B22222", "Juan", "Brenes", 21));
            this.arrayListEstudiantes.Add(new Estudiante("B33333", "Pablo", "Mora", 21));
            this.arrayListEstudiantes.Add(new Estudiante("B44444", "Carlos", "Salas", 21));
        }

        public ArrayList ArrayListEstudiantes { get => arrayListEstudiantes; set => arrayListEstudiantes = value; }
    }
}
