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

namespace DataAccessLayer.Repositories
{
    public class RecipeTypesRepository : IRecipeTypesRepository
    {
        public event Action<string> OnError;
        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }
        public async Task AddRecipeType(RecipeType recipeType)
        {
            try
            {
                string query = @"insert into RecipeTypes
                (Name) values (@Name)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeType);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while adding recipe type.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task<List<RecipeType>> GetRecipeTypes()
        {
            try
            {
                string query = "select * from RecipeTypes";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while getting recipe types.";
                ErrorOccured(errorMessage);
                return new List<RecipeType>();
            }
        }
    }
}
