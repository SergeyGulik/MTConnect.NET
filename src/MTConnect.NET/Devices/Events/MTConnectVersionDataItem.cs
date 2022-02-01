// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

namespace MTConnect.Devices.Events
{
    /// <summary>
    /// The reference version of the MTConnect Standard supported by the Adapter.
    /// </summary>
    public class MTConnectVersionDataItem : DataItem
    {
        public const DataItemCategory CategoryId = DataItemCategory.EVENT;
        public const string TypeId = "MTCONNECT_VERSION";
        public const string NameId = "mtconnectVersion";


        public MTConnectVersionDataItem()
        {
            DataItemCategory = CategoryId;
            Type = TypeId;
        }

        public MTConnectVersionDataItem(string parentId)
        {
            Id = CreateId(parentId, NameId);
            DataItemCategory = CategoryId;
            Type = TypeId;
            Name = NameId;
        }
    }
}