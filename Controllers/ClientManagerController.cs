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
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(Client), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Client> GetClient(int id)
    {
        var client = ClientServices.GetClient(id);
        if (client is null)
            return NotFound();
        return Ok(client);
    }
    [HttpPost]
    [ProducesResponseType(typeof(Client), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Create(Client client)
    {
        ClientServices.Add(client);
        return CreatedAtAction(nameof(GetClient), new { id = client.id }, client);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Update(int id, Client client)
    {
        if (id != client.id)
            return BadRequest();
        var existingClient = ClientServices.GetClient(id);
        if (existingClient is null)
            return NotFound();
        ClientServices.Update(client);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    { 
        var client = ClientServices.GetClient(id);
        if (client is null)
            return NotFound();
        ClientServices.Delete(id);
        return NoContent();
    }
    [HttpPost]
    [Route("partial/{id}")]
    public IActionResult UpdatePartial(int id, Client client)
    {
        var existingClient = ClientServices.GetClient(id);
        if (existingClient is null)
            return NotFound();
        ClientServices.UpdatePartial(id, client);
        return NoContent();
    }
}
