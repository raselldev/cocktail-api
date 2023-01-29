using System;
using System.Linq;
using cocktail_api.Data;
using cocktail_api.Models;
using cocktail_api.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace cocktail_api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CocktailController: ControllerBase
	{
		private readonly DataContext _context;

		public CocktailController(ICocktailAPI cocktail, DataContext context)
		{
			_context = context;
        }

        [SwaggerOperation
            (
                Summary = "Get Cocktail Data",
                Description = "This endpoint use to cocktail data using pagination"
            )
        ]
        [HttpGet("page/{page}")]
        public IActionResult GetByPagination(int page)
		{
            var cocktails = _context.Cocktails
				.Select(s => new
				{
					s.Id,
					s.StrDrink,
					s.StrCategory,
					s.StrAlcoholic,
					s.StrDrinkThumb

				})
				.Skip(page)
				.Take(25)
				.OrderBy(s => s.StrDrink)
                .ToList();

            return Ok(new { result = cocktails });
        }

        [SwaggerOperation
            (
                Summary = "Get Detail Cocktail",
                Description = "This endpoint use to cocktail detail data"
            )
        ]
        [HttpGet("detail/{id}")]
        public IActionResult GetDetail(Guid id)
        {
            var cocktails = _context.Cocktails
                .Where(i => i.Id == id)
                .Select(s => new
                {
                    s.Id,
                    s.StrDrink,
                    s.StrTags,
                    s.StrCategory,
                    s.StrAlcoholic,
                    s.StrGlass,
                    s.StrInstructions,
                    s.StrDrinkThumb,
                    s.StrIngredient1,
                    s.StrIngredient2,
                    s.StrIngredient3,
                    s.StrIngredient4,
                    s.StrIngredient5,
                    s.StrIngredient6,
                    s.StrIngredient7,
                    s.StrIngredient8,
                    s.StrIngredient10,
                    s.StrIngredient11,
                    s.StrIngredient12,
                    s.StrIngredient13,
                    s.StrIngredient14,
                    s.StrIngredient15,
                    s.StrMeasure1,
                    s.StrMeasure2,
                    s.StrMeasure3,
                    s.StrMeasure4,
                    s.StrMeasure5,
                    s.StrMeasure6,
                    s.StrMeasure7,
                    s.StrMeasure8,
                    s.StrMeasure9,
                    s.StrMeasure10,
                    s.StrMeasure11,
                    s.StrMeasure12,
                    s.StrMeasure13,
                    s.StrMeasure14,
                    s.StrMeasure15,
                    s.StrImageSource
                });

            return Ok(new { result = cocktails });
        }

        [SwaggerOperation
            (
                Summary = "Get All Cocktail Data",
                Description = "This endpoint use to get all cocktail data"
            )
        ]
        [HttpGet()]
        public IActionResult GetAll()
        {
            var cocktails = _context.Cocktails
                .Select(s => new
                {
                    s.Id,
                    s.StrDrink,
                    s.StrCategory,
                    s.StrAlcoholic,
                    s.StrDrinkThumb

                })
                .OrderBy(s => s.StrDrink)
                .ToList();

            return Ok(new{ result = cocktails });
        }
    }
}




