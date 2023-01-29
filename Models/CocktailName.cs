using System;
using System.Text.Json.Serialization;

namespace cocktail_api.Models
{
	public class CocktailName
	{
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
	}

	public class Name
	{
		[JsonPropertyName("id")]
		public string IdDrink { get; set; }

        [JsonPropertyName("strDrink")]
        public string strDrink { get; set; }
	}
}

