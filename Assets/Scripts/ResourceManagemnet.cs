using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ResourceManagement
{
    class ResourceData : Dictionary<string, double>
    {
        public ResourceData(): this(DataHelper.ToDictinary())
        {
        }

        public ResourceData(Dictionary<string, double> resources)
        {
            foreach(var kv in resources)
            {
                this[kv.Key] = kv.Value;
            }
        }
    }

    class ResourceEngine
    {
        
        public static Dictionary<string, Recipe> recipe = new Dictionary<string, Recipe>()
        {
            {"OtoO2",
                new Recipe("OtoO2", new Dictionary<string,double>{ { "O",2f} },
                    new Dictionary<string,double>{ { "O2",1f} }) },
            {"O2toO",
                new Recipe("O2toO", new Dictionary<string,double>{ { "O2",1f } },
                    new Dictionary<string, double>{ { "O",2f} }) },
            {"MakeFood",
                new Recipe("MakeFood", new Dictionary<string,double>{ {"CO2",6f },{ "H2O",12f},{ "E",1f} },
                    new Dictionary<string, double>{ { "food",1f},{ "O2",6f},{ "H2O",6f} }) },
            {"Breath",
                new Recipe("Breath", new Dictionary<string, double>{ { "food",1f},{ "O2",6f},{ "H2O",6f} },
                    new Dictionary<string,double>{ {"CO2",6f },{ "H2O",12f},{ "E",1f} }) },
            {"CleanH2O",
                new Recipe("CleanH2O", new Dictionary<string, double>{ { "H2O_soiled",1f } },
                    new Dictionary<string, double>{ { "H2O", 1f } }) },
            {"DirtyH2O",
                new Recipe("DirtyH2O", new Dictionary<string, double>{ { "H2O",1f} },
                    new Dictionary<string, double>{ { "H2O_soiled",1f} }) },
            {"CleanO2",
                new Recipe("CleanO2", new Dictionary<string, double>{ { "CO2",1f} },
                    new Dictionary<string, double>{ { "C",1f},{ "O2",1f} }) },
            {"BurnC",
                new Recipe("BurnC", new Dictionary<string, double>{ { "C",1f},{ "O2",1f} },
                    new Dictionary<string, double>{ { "CO2",1f} }) },
            {"H2ODivide",
                new Recipe("H2ODivide", new Dictionary<string, double>{ { "H2O",1f} },
                    new Dictionary<string, double>{ { "H",2f} ,{ "O",1f} }) },
            {"FuelCell",
                new Recipe("FuelCell", new Dictionary<string, double>{ { "H",2f},{ "O",1f} },
                    new Dictionary<string, double>{ { "H2O",1f} }) }
        };

        public static void DoConvert(ResourceData data, Recipe recipe, double count)
        {
            
            double possibility = -1;
            
            foreach (var req in recipe.requirements)
            {
                if (possibility == -1)
                {
                    possibility = data[req.Key] / req.Value;
                }
                else if (possibility > data[req.Key] / req.Value)
                {
                    possibility = data[req.Key] / req.Value;
                }
            }
            count = Math.Min(possibility, count);

            foreach (var req in recipe.requirements)
            {
                data[req.Key] -= req.Value * count;
            }
            foreach (var req in recipe.outputs)
            {
                data[req.Key] += req.Value * count;
            }
        
            
        }

    }

    class Recipe
    {
        public string name;
        public Dictionary<string, double> requirements;
        public Dictionary<string, double> outputs;

        public Recipe(string name, Dictionary<string, double> requirements, Dictionary<string, double> outputs)
        {
            this.name = name;
            this.requirements = requirements;
            this.outputs = outputs;
        }

    }

    static class DataHelper
    {
        public static Dictionary<string, double> ToDictinary(
            double O = 0, double O2 = 0, double CO2 = 0,double C = 0, double H = 0,
            double H2O = 0, double H2O_soiled = 0, double E = 0, double food = 0)
        {
            return new Dictionary<string, double>
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
