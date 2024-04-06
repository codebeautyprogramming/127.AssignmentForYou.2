using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int RecipeTypeId { get; set; }

        public Recipe(string name, string description, byte[]? image, int recipeTypeId)
        {
            Name = name;
            Description = description;
            Image = image;
            RecipeTypeId = recipeTypeId;
        }
        public Recipe() { }
    }
}
