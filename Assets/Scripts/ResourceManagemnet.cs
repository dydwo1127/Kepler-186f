using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourceManagement
{
    class ResourceData
    {
        Dictionary<string, float> resources;
        public ResourceData(Dictionary<string, float> resources)
        {
            this.resources = resources;
        }
    }

    static class ResourceEngine
    {
        static List<Recipe> recipe = new List<Recipe>()
        {   
            new Recipe("OtoO2",new Dictionary<string,float>{ { "O",2f} },new Dictionary<string,float>{ { "O2",1f} })
        };

        static List<Recipe> Filter(ResourceData data)
        {

        }

        static void DoConvert(ResourceData data, Recipe recipe, int count)
        {

        }

    }

    class Recipe
    {
        string name;
        Dictionary<string, float> requirements;
        Dictionary<string, float> outputs;

        Recipe(string name, Dictionary<string, float> requirements, Dictionary<string, float> outputs)
        {
            this.name = name;
            this.requirements = requirements;
            this.outputs = outputs;
        }

    }

    static class DataHelper
    {
        public static Dictionary<string, float> ToDictinary(
            float O = 0, float O2 = 0, float CO2 = 0, float C = 0, float H = 0,
            float H2O = 0, float H2O_soiled = 0, float E = 0, float food = 0)
        {
            return new Dictionary<string, float>
            {
                  { "O" , O },
                  { "O2" , O2 },
                  { "CO2" , CO2 },
                  { "C" , C },
                  { "H" , H },
                  { "H2O" , H2O},
                  { "H2O_soiled" ,H2O_soiled },
                  { "E" , E },
                  { "Food" , food }
            };
        }
    }
}
