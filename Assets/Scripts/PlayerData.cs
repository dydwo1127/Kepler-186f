//<<<<<<< HEAD
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ResourceManagement;

namespace PlayerData
{
    class ShipData
    {
        double O2_total;
        double CO2_total;
        double H2O_total;
        public static int TurnCount;
        

        Dictionary<int, ResourceData> resources = new Dictionary<int, ResourceData>()
        {
            {1, new ResourceData() },
            {2, new ResourceData() },
            {3, new ResourceData() },
            {4, new ResourceData() },
            {5, new ResourceData() },
            {6, new ResourceData() },
            {7, new ResourceData() },
            {8, new ResourceData() },
            {9, new ResourceData() },
            {10, new ResourceData() }
        };

        public void UseResources(int[] sectorNum, Recipe recipe, double count)
        {
            foreach(int sector in sectorNum)
            {
                ResourceEngine.DoConvert(resources[sector], recipe, count);
            }
        }
    }

    class Person
    {
        string name = "defaultName";
        int age;
        float happiness;

    }
}
//=======
﻿//using System;
//using System.Collections;
//using System.Collections.Generic;
//using ResourceManagement;

//namespace PlayerData
//{
//    class ShipData
//    {
//        double O2_total;
//        double CO2_total;

//        Dictionary<int, ResourceData> resources = new Dictionary<int, ResourceData>()
//        {
//            {1, new ResourceData(O:100f) },
//            {2, new ResourceData(100f,100f,100f,100f,100f,100f,100f,100f,100f) }
//        };
//    }
//}
//>>>>>>> 4a6e77047c0631397ad561b1c7b31be0590e5208
