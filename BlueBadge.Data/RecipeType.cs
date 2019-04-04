using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public class RecipeType
    {
        [Key]
        public int RecipeKind { get; set; }

        [Required]
        public string TypeName { get; set; }

        [Required]
        public string Dietary { get; set; }


    }
}
