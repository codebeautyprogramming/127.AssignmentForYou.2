using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Xml.Linq;
using DataAccessLayer.CustomQueryResults;

namespace DataAccessLayer.Repositories
{
    public class RecipesRepository : IRecipesRepository
    {
        public event Action<string> OnError;
        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }
        public async Task AddRecipe(Recipe recipe)
        {
            try
            {
                string query = @"insert into Recipes 
                (Name, Description, Image, RecipeTypeId) 
                values (@Name, @Description, @Image, @RecipeTypeId)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }
            }
            catch (SqlException sqlEx)
            {
                string errorMessage = "";
                if (sqlEx.Number == 2627)
                    errorMessage = "That recipe already exists.";
                else
                    errorMessage = "An error happened in the database.";
                ErrorOccured(errorMessage);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while adding recipe.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task<List<RecipeWithType>> GetRecipes()
        {
            try
            {
                string query = @"select r.Id, r.Name, r.Description, rt.Name as 'Type', r.RecipeTypeId, r.Image
                                from Recipes as r join RecipeTypes as rt
                                on r.RecipeTypeId = rt.Id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeWithType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while getting recipes.";
                ErrorOccured(errorMessage);
                return new List<RecipeWithType>();
            }
        }
        public async Task DeleteRecipe(int Id)
        {
            try
            {
                string query = @$"delete from Recipes where Id={Id}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while deleting recipe.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task EditRecipe(Recipe recipe)
        {
            try
            {
                string query = @"update Recipes
                             set
                             Name = @Name,
                             Description = @Description,
                             RecipeTypeId = @RecipeTypeId,
                             where Id = @Id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while editing recipe.";
                ErrorOccured(errorMessage);
            }

        }
    }
}
