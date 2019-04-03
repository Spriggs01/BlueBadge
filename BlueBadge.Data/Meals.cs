using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
 public   class Meals
    {

        public Guid UserID { get; set; }
        public int RecipeID { get; set; }
        public int MealID { get; set; }
        public int MealKindID { get; set; }
    }
}
