// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using MTConnect.Devices.DataItems.Samples;

namespace MTConnect.Observations.Samples.Values
{
    /// <summary>
    /// The measurement of the rate of change of angular position.
    /// </summary>
    public class AngularVelocityValue : SampleValue
    {
        public AngularVelocityValue(double nativeValue, string nativeUnits = AngularVelocityDataItem.DefaultUnits)
        {
            Value = nativeValue;
            _units = AngularVelocityDataItem.DefaultUnits;
            _nativeUnits = nativeUnits;
        }
    }
}
