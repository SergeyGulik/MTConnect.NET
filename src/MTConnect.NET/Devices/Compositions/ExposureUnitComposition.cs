// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace MTConnect.Devices.Compositions
{
    /// <summary>
    /// A mechanism for emitting a type of radiation.
    /// </summary>
    public class ExposureUnitComposition : Composition 
    {
        public const string TypeId = "EXPOSURE_UNIT";
        public const string NameId = "expunit";

        public ExposureUnitComposition()  { Type = TypeId; }
    }
}