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
    }
    
    class ResourceData
    {
        Dictionary<string, float> resources = new Dictionary<string, float>()
        {
            { "O" , 100f },
            { "O2" , 100f },
            { "CO2" , 100f },
            { "C" , 100f },
            { "H" , 100f },
            { "H2O" , 100f },
            { "H2O_soiled" , 100f },
            { "E" , 100f },
            { "Food" , 100f }
        };
    }

    static class ResourceEngine
    {
        static List<Recipe> recipe = new List<Recipe>()
        {

        };

        static List<Recipe> Filter(ResourceData data)
        {

        }

        static void DoConvert(ResourceData data, Recipe recipe, int count)
        {

        }
        
    }
}
