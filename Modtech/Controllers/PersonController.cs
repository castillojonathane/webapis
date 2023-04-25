using Microsoft.AspNetCore.Mvc;
using Modtech_API.Modelos;
using Modtech_API.Modelos.DTO;

namespace Modtech_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public IEnumerable<PersonDto> GetPerson()
    {
        return PersonStore.personList;
    }

    [HttpGet]
    public PersonDto GetPerson(Guid Id)
    {
        return PersonStore.personList.FirstOrDefault( c => c.Id.Equals(Id));
    }
}
