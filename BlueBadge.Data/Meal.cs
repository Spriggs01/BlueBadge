using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public enum MealType
    {
        mealType, MealDescription 

    }

 public   class Meal
    {

        public Guid UserID { get; set; }
        public int RecipeID { get; set; }

        [Key]
        public int MealID { get; set; }
        
        public MealType TypeOfMeal { get; set; }
    }
}
