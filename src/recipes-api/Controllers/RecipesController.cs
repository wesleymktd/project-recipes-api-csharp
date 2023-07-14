using Microsoft.AspNetCore.Mvc;
using recipes_api.Services;
using recipes_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace recipes_api.Controllers;

[ApiController]
[Route("recipe")]
public class RecipesController : ControllerBase
{    
    public readonly IRecipeService _service;
    
    public RecipesController(IRecipeService service)
    {
        this._service = service;        
    }

    // 1 - Sua aplicação deve ter o endpoint GET /recipe
    //Read
    [HttpGet]
    public IActionResult Get()
    {
        var recipes = _service.GetRecipes();
        return Ok(recipes);  
    }

    // 2 - Sua aplicação deve ter o endpoint GET /recipe/:name
    //Read
    [HttpGet("{name}", Name = "GetRecipe")]
    public IActionResult Get(string name)
    {                
        var recipe = _service.GetRecipe(name);
        if (recipe == null) return NotFound("receita não encontrada");
        return Ok(recipe);
    }

    // 3 - Sua aplicação deve ter o endpoint POST /recipe
    [HttpPost]
    public IActionResult Create([FromBody]Recipe recipe)
    {
        _service.AddRecipe(recipe);
        var createdRecipe = _service.GetRecipe(recipe.Name);

        if (createdRecipe == null) return NotFound("Falha ao criar a receita");

        return CreatedAtAction(nameof(Get), new { name = recipe.Name}, createdRecipe);
    }

    // 4 - Sua aplicação deve ter o endpoint PUT /recipe
    [HttpPut("{name}")]
    public IActionResult Update(string name, [FromBody]Recipe recipe)
    {
        try
        {
            _service.UpdateRecipe(recipe);
            recipe.Name = name;
            return NoContent();
        }
        catch
        {
            
            return BadRequest();
        }
    }

    // 5 - Sua aplicação deve ter o endpoint DEL /recipe
    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        var recipe = _service.GetRecipe(name);
        if (recipe == null) return NotFound("receita não encontrada");
        _service.DeleteRecipe(name);
        return NoContent();
    }    
}
