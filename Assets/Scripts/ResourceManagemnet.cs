using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourceManagement
{
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

    class ResourceData
    {
        Dictionary<string, float> resources;
        public ResourceData(float O,float O2, float CO2, float C, float H,float H2O,float H2O_soiled,float E,float food)
        {
            this.resources = new Dictionary<string, float>
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
}
