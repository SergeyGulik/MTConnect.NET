// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace MTConnect.Assets.CuttingTools.Measurements.Assembly
{
    /// <summary>
    /// The dimension of the height of the shank.
    /// </summary>
    public class ShankHeightMeasurement : AssemblyMeasurement
    {
        public const string TypeId = "ShankHeight";
        public const string CodeId = "H";


        public ShankHeightMeasurement()
        {
            Type = TypeId;
            Code = CodeId;
            Units = Devices.Units.MILLIMETER;
        }

        public ShankHeightMeasurement(double value)
        {
            Type = TypeId;
            Code = CodeId;
            Units = Devices.Units.MILLIMETER;
            CDATA = value;
        }
    }
}