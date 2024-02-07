using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{       
    public EventoController()
    {
        
    }

     public IEnumerable<Evento> _evento = new Evento[]
     {        
        new Evento()
        {
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "São Paulo",
            Lote = "1º Lote",
            QtdePessoas = 250,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto1.jpg"
        },
        new Evento()
        {
            EventoId = 2,
            Tema = "Angular e suas novidades",
            Local = "Belo Horizonte",
            Lote = "2º Lote",
            QtdePessoas = 350,
            DataEvento = DateTime.Now.AddDays(6).ToString("dd/MM/yyyy"),
            ImagemURL = "foto2.jpg"

        }       
    };
     

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
       return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
       return "Exemplo de Post!!!";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"Exemplo de Put com id = {id}!!!";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"Exemplo de Delete com id = {id}!!!";
    }
}
