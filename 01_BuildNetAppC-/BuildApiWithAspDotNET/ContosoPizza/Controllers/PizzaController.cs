/* this class derives from ControllerBase, the base class for working with HTTP requests in ASP.NET Core. 
It also includes the two standard attributes you learned about: [ApiController] and [Route]. 
As before, the [Route] attribute defines a mapping to the [controller] token. 
Because this controller class is named PizzaController, 
this controller handles requests to https://localhost:{PORT}/pizza.*/

using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    //GET all action
    //. Responds only to the HTTP GET verb, as denoted by the [HttpGet] attribute.
    //. Returns an ActionResult instance of type List<Pizza>. 
    //. The ActionResult type is the base class for all action results in ASP.NET Core.
    //. Queries the service for all pizza and automatically returns data with a Content-Type value of application/json.
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
    PizzaService.GetAll();

    //GET by Id action
    //. Responds only to the HTTP GET verb, as denoted by the [HttpGet] attribute.
    //. Requires that the id parameter's value is included in the URL segment after pizza/. Remember, the controller-level [Route] attribute defined the /pizza pattern.
    //. Queries the database for a pizza that matches the provided id parameter.
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }

    //POST action
    //. Responds only to the HTTP POST verb, as denoted by the [HttpPost] attribute.
    //. Inserts the request body's Pizza object into the in-memory cache.
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    //PUT action
    //. Responds only to the HTTP PUT verb, as denoted by the [HttpPut] attribute.
    //. Requires that the id parameter's value is included in the URL segment after pizza/.
    //. Returns IActionResult, because the ActionResult return type isn't known until runtime. 
    //...The BadRequest, NotFound, and NoContent methods return BadRequestResult, NotFoundResult, and NoContentResult types, respectively.

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();

        var existingPizza = PizzaService.Get(id);
        if (existingPizza is null)
            return NotFound();

        PizzaService.Update(pizza);

        return NoContent();
    }

    //DELETE action
    //. Responds only to the HTTP DELETE verb, as denoted by the [HttpDelete] attribute.
    //. Requires that the id parameter's value is included in the URL segment after pizza/.
    //. Returns IActionResult because the ActionResult return type isn't known until runtime. 
    //...The NotFound and NoContent methods return NotFoundResult and NoContentResult types, respectively.
    //. Queries the in-memory cache for a pizza that matches the provided id parameter.
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza is null)
            return NotFound();

        PizzaService.Delete(id);

        return NoContent();
    }
}