using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventosController : ControllerBase
    {
        public EventosController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[]{
             new Evento(){
                    EventoId = 1,
                    Tema= "Angular 11 e .NET 5",
                    Local= "Sao Paulo",
                    Lote= "1 Lote",
                    QtdPessoas= 250,
                    DataEvento= DateTime.Now.AddDays(2).ToString()
                },
                new Evento(){
                    EventoId = 2,
                    Tema= "Angular e sua novidades",
                    Local= "Sao Paulo",
                    Lote= "2 Lote",
                    QtdPessoas= 250,
                    DataEvento= DateTime.Now.AddDays(2).ToString()
                },
                new Evento(){
                    EventoId = 3,
                    Tema= ".NET 5",
                    Local= "Sao Paulo",
                    Lote= "1 Lote",
                    QtdPessoas= 250,
                    DataEvento= DateTime.Now.AddDays(2).ToString()
                },
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return this._evento;
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return this._evento.Where(evento => evento.EventoId == id);            
        }
        
        [HttpPost]
        public string Post()
        {
            return "Exemplo des Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo des Put com ID = {id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo des Delete com ID = {id}";
        }
        
    }
}