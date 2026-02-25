using Microsoft.AspNetCore.Mvc;

namespace ClientManager.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientManagerController : ControllerBase
{
    private static readonly string[] Clients = new[]
    {
        
    };

    private readonly ILogger<ClientManagerController> _logger;

    public ClientManagerController(ILogger<ClientManagerController> logger)
    {
        _logger = logger;
    }

   
}
