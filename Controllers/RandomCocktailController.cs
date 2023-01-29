using System;
using System.Threading;
using cocktail_api.Data;
using cocktail_api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Swashbuckle.AspNetCore.Annotations;


namespace cocktail_api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
    public class RandomCocktailController : ControllerBase
	{
        private readonly DataContext _context;
        private readonly ICocktailAPI _cocktailApi;

		public RandomCocktailController(ICocktailAPI cocktailAPI, DataContext context)
		{
			_cocktailApi = cocktailAPI;
			_context = context;
		}

        [SwaggerOperation
			(
				Summary = "Generate Data",
				Description = "This endpoint use to get random data from CocktailDB and make sure there isn't any yet in database."
            )
		]
        [HttpGet]
		public async Task<IActionResult> GetRandomCocktail()
		{

			var cocktails = await _cocktailApi.GetCocktails();

            var idDrink = cocktails.Drinks[0].IdDrink;

			var exist = _context.Cocktails
				.FirstOrDefault(e => e.IdDrink == idDrink);

			if(exist is null)
			{
				_context.Cocktails.Add(cocktails.Drinks[0]);
				_context.SaveChanges();
				return Ok(new { result = "Inserted" }) ;
            }
			else
			{
				return Ok(new {result = "Data Has Been Added",});
			}
		}
	}
}

