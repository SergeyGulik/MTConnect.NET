// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using MTConnect.Observations;
using MTConnect.Observations.Input;
using System;

namespace MTConnect.Devices.DataItems.Events
{
    /// <summary>
    /// The current state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.
    /// </summary>
    public class EmergencyStopDataItem : DataItem
    {
        public const DataItemCategory CategoryId = DataItemCategory.EVENT;
        public const string TypeId = "EMERGENCY_STOP";
        public const string NameId = "estop";
        public new const string DescriptionText = "The current state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.";

        public override string TypeDescription => DescriptionText;

        public override Version MinimumVersion => MTConnectVersions.Version11;


        public EmergencyStopDataItem()
        {
            Category = CategoryId;
            Type = TypeId;
        }

        public EmergencyStopDataItem(string parentId)
        {
            Id = CreateId(parentId, NameId);
            Category = CategoryId;
            Type = TypeId;
            Name = NameId;
        }


        /// <summary>
        /// Determine if the DataItem with the specified Observation is valid in the specified MTConnectVersion
        /// </summary>
        /// <param name="mtconnectVersion">The Version of the MTConnect Standard</param>
        /// <param name="observation">The Observation to validate</param>
        /// <returns>A DataItemValidationResult indicating if Validation was successful and a Message</returns>
        protected override ValidationResult OnValidation(Version mtconnectVersion, IObservationInput observation)
        {
            if (observation != null && !observation.Values.IsNullOrEmpty())
            {
                // Get the CDATA Value for the Observation
                var cdata = observation.GetValue(ValueKeys.CDATA);
                if (cdata != null)
                {
                    // Check Valid values in Enum
                    var validValues = Enum.GetValues(typeof(Observations.Events.Values.EmergencyStop));
                    foreach (var validValue in validValues)
                    {
                        if (cdata == validValue.ToString())
                        {
                            return new ValidationResult(true);
                        }
                    }

                    return new ValidationResult(false, "'" + cdata + "' is not a valid value");
                }
                else
                {
                    return new ValidationResult(false, "No CDATA is specified for the Observation");
                }
            }

            return new ValidationResult(false, "No Observation is Specified");
        }
    }
}
