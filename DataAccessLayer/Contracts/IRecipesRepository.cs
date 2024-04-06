using DataAccessLayer.CustomQueryResults;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface IRecipesRepository
    {
        public event Action<string> OnError;
        public Task AddRecipe(Recipe recipe);
        public Task<List<RecipeWithType>> GetRecipes();
        public Task DeleteRecipe(int Id);
        public Task EditRecipe(Recipe recipe);
       
    }
}
