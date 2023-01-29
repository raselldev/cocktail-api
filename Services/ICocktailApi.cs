using System;
using cocktail_api.Models;
namespace cocktail_api.Services
{
	public interface ICocktailAPI
	{
        Task<Cocktail> GetCocktails();
	}
}


