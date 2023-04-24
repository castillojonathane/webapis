using Microsoft.AspNetCore.Mvc;
using Modtech_API.Modelos;

namespace Modtech_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Person> GetPerson()
    {
        return new List<Person>
        {
            new Person{Id= Guid.NewGuid() ,Nombre="Jonha Castillo"},
            new Person{Id= Guid.NewGuid() ,Nombre="Vale Castillo"}
        };
    }
}
