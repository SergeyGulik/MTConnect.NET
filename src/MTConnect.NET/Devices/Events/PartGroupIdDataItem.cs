// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

namespace MTConnect.Devices.Events
{
    /// <summary>
    /// Identifier given to a collection of individual parts.If no subType is specified, UUID is default.
    /// </summary>
    public class PartGroupIdDataItem : DataItem
    {
        public const DataItemCategory CategoryId = DataItemCategory.EVENT;
        public const string TypeId = "PART_GROUP_ID";
        public const string NameId = "partGroupId";

        public enum SubTypes
        {
            /// <summary>
            /// An identifier that references a group of parts produced in a batch.
            /// </summary>
            BATCH,

            /// <summary>
            /// An identifier used to reference a material heat number.
            /// </summary>
            HEAT_TREAT,

            /// <summary>
            /// An identifier that references a group of parts tracked as a lot.
            /// </summary>
            LOT,

            /// <summary>
            /// Material that is used to produce parts.
            /// </summary>
            RAW_MATERIAL,

            /// <summary>
            /// The globally unique identifier as specified in ISO 11578 or RFC 4122.
            /// </summary>
            UUID
        }


        public PartGroupIdDataItem()
        {
            DataItemCategory = CategoryId;
            Type = TypeId;
        }

        public PartGroupIdDataItem(
            string parentId,
            SubTypes subType = SubTypes.UUID
            )
        {
            Id = CreateId(parentId, NameId, GetSubTypeId(subType));
            DataItemCategory = CategoryId;
            Type = TypeId;
            SubType = subType.ToString();
            Name = NameId;
        }


        public static string GetSubTypeId(SubTypes subType)
        {
            switch (subType)
            {
                case SubTypes.BATCH: return "batch";
                case SubTypes.HEAT_TREAT: return "heatTreat";
                case SubTypes.LOT: return "lot";
                case SubTypes.RAW_MATERIAL: return "rawMaterial";
                case SubTypes.UUID: return "uuid";
            }

            return null;
        }
    }
}