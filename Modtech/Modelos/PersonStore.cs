using Modtech_API.Modelos.DTO;

namespace Modtech_API.Modelos;

public static class PersonStore
{
    public static List<PersonDto> personList = new List<PersonDto>
    {
        new PersonDto{ Id = new Guid("f64f353f-1d7b-4ee2-8040-fa918360b683"), Nombre = "Jonathan Castillo"},
        new PersonDto{ Id = new Guid("78fa9067-9edf-4ec8-bf92-34cec310873a"), Nombre = "Valentin Castillo"},
    };
}
