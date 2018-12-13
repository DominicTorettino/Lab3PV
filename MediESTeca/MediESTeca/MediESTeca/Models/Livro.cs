using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediESTeca.Models
{
    // Nivel 2C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 3\MediESTeca\MediESTeca\MediESTeca\Models\Livro.cs
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Isbn { get; set; }
        public int AnoEdicao { get; set; }
        public bool EmDestaque { get; set; }
    }
}
