using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public class FavoriteRecipe
    {
        [Key]
        public int FavoriteRecipeID { get; set; }
        public Guid UserID { get; set; }
        public int RecipeID { get; set; }
    }
}
