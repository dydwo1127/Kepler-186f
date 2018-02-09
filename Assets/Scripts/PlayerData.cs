using System;
using System.Collections;
using System.Collections.Generic;
using ResourceManagement;

namespace PlayerData
{
    class ShipData
    {
        double O2_total;
        double CO2_total;

        Dictionary<int, ResourceData> resources = new Dictionary<int, ResourceData>()
        {
            {1, new ResourceData(O:100f) },
            {2, new ResourceData(100f,100f,100f,100f,100f,100f,100f,100f,100f) }
        };
    }
}