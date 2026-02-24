using Microsoft.AspNetCore.Mvc;

namespace ClientManager.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientManagerController : ControllerBase
{
    private static readonly string[] Clients = new[]
    {
        "1","João","Gens","32","joaogens@it.pt","919999999",
        "2","Maria","Silva","28","mariasilva@it.pt","919888888",
        "3","Pedro","Santos","35","pedrosantos@it.pt","919777777",
        "4","Ana","Costa","30","anacosta@it.pt","919666666",
        "5","Luís","Ferreira","40","luisf@it.pt","919555555",
        "6","Carla","Pereira","27","carlap@it.pt","919444444",
    };

    private readonly ILogger<ClientManagerController> _logger;

    public ClientManagerController(ILogger<ClientManagerController> logger)
    {
        _logger = logger;
    }

   
}
