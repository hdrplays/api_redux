using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Redux.Models
{
    public class Desenvolvedor
    {
        public Desenvolvedor() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public string Hobby { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}