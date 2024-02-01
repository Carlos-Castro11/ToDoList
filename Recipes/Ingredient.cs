using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    public class Ingredient
    {
        private String Name {  get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
