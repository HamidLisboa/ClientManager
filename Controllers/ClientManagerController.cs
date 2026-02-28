using Microsoft.AspNetCore.Mvc;
using ClientManager.Services;
using ClientManager.Models;

namespace ClientManager.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientManagerController : ControllerBase
{
    public ClientManagerController()
    {
        
    }

    [HttpGet]
    public ActionResult<List<Client>> GetAll()
    {
        return ClientServices.GetAll();
	}
    [HttpGet("{id}")]
    public ActionResult<Client> GetClient(int id)
    {
        var client = ClientServices.GetClient(id);
        if (client is null)
            return NotFound();
        return client;
	}
}
