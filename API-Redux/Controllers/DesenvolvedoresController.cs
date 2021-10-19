using API_Redux.Models;
using API_Redux.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_Redux.Controllers
{
    public class DesenvolvedoresController : ApiController
    {
        private static List<Desenvolvedor> desenvolvedores = new List<Desenvolvedor>();

        private Context context;

        [HttpGet]
        public List<Desenvolvedor> GetDesenvolvedores()
        {
            context = new Context();

            return context.Desenvolvedor.ToList();
        }

        [HttpGet]
        public Desenvolvedor GetDesenvolvedor(int id)
        {
            context = new Context();

            var entity = context.Desenvolvedor.Where(w => w.Id.Equals(id)).FirstOrDefault();
            if (entity != null)
                return entity;

            //retornar 404
            return entity;
        }

        [HttpPost]
        public Desenvolvedor Inserir(Desenvolvedor desenvolvedor)
        {
            context = new Context();

            if (desenvolvedor != null)
                desenvolvedores.Add(desenvolvedor);

            context.Set<Desenvolvedor>().Add(desenvolvedor);
            context.SaveChanges();

            return desenvolvedor;
        }

        [HttpDelete]
        public void DeleteDesenvolvedores(int id)
        {
            context = new Context();
            
            var entity = context.Desenvolvedor.Where(w => w.Id.Equals(id)).FirstOrDefault();
            if (entity != null)
                desenvolvedores.Remove(entity);

            context.Set<Desenvolvedor>().Remove(entity);
            context.SaveChanges();
        }

        [HttpPut]
        public void PutDesenvolvedores(Desenvolvedor desenvolvedor)
        {
            var dev = context.Desenvolvedor.Where(w => w.Id == desenvolvedor.Id).FirstOrDefault();
            if(dev != null)
            {
                dev.Nome = desenvolvedor.Nome;
                dev.Sexo = desenvolvedor.Sexo;
                dev.Idade = desenvolvedor.Idade;
                dev.Hobby = desenvolvedor.Hobby;
                dev.DataNascimento = desenvolvedor.DataNascimento;

                context.Set<Desenvolvedor>().Add(desenvolvedor);
                context.SaveChanges();
            }
        }
    }
}
