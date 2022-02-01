// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using MTConnect.Devices.Compositions;

namespace MTConnect.Models.Compositions
{
    /// <summary>
    /// A component consisting of one or more cells, in which chemical energy is converted into electricity and used as a source of power.
    /// </summary>
    public class StorageBatteryModel : CompositionModel, IStorageBatteryModel
    {
        public StorageBatteryModel() 
        {
            Type = StorageBatteryComposition.TypeId;
        }

        public StorageBatteryModel(string compositionId)
        {
            Id = compositionId;
            Type = StorageBatteryComposition.TypeId;
        }
    }
}