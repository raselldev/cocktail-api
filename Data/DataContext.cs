using System;
using cocktail_api.Models;
using Microsoft.EntityFrameworkCore;
namespace cocktail_api.Data
{
	public class DataContext: DbContext
	{
		public DbSet<Drink> Cocktails { get; set; }

		public DataContext(DbContextOptions<DataContext> options): base(options)
		{
		}
	}
}

