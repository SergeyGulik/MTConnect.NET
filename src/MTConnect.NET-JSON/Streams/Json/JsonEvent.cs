// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using MTConnect.Observations;
using System.Linq;
using MTConnect.Streams.Output;
using MTConnect.Observations.Output;
using MTConnect.Devices.DataItems;

namespace MTConnect.Streams.Json
{
    /// <summary>
    /// An abstract XML Element. Replaced in the XML document by type(s) of Sample XML elements representing SAMPLE category data items defined for a Device in the Device Information Model.
    /// There can be multiple types of Sample XML Elements in a Samples container.
    /// </summary>
    public class JsonEvent : JsonObservation
    {
        public JsonEvent() { }

        public JsonEvent(IObservation e)
        {
            if (e != null)
            {
                DataItemId = e.DataItemId;
                Timestamp = e.Timestamp;
                Name = e.Name;
                Sequence = e.Sequence;
                Type = e.Type;
                SubType = e.SubType;
                CompositionId = e.CompositionId;
                Result = e.GetValue(ValueKeys.Result);
                ResetTriggered = e.GetValue(ValueKeys.ResetTriggered);

                // DataSet Entries
                if (e is EventDataSetObservation)
                {
                    Entries = CreateEntries(((EventDataSetObservation)e).Entries);
                    Count = !Entries.IsNullOrEmpty() ? Entries.Count() : 0;
                }

                // Table Entries
                if (e is EventTableObservation)
                {
                    Entries = CreateEntries(((EventTableObservation)e).Entries);
                    Count = !Entries.IsNullOrEmpty() ? Entries.Count() : 0;
                }
            }
        }

        public JsonEvent(IObservationOutput e)
        {
            if (e != null)
            {
                DataItemId = e.DataItemId;
                Timestamp = e.Timestamp;
                Name = e.Name;
                Sequence = e.Sequence;
                Type = e.Type;
                SubType = e.SubType;
                CompositionId = e.CompositionId;
                Result = e.GetValue(ValueKeys.Result);
                ResetTriggered = e.GetValue(ValueKeys.ResetTriggered);

                // DataSet Entries
                if (e.Representation == DataItemRepresentation.DATA_SET)
                {
                    var dataSetObservation = new EventDataSetObservation();
                    dataSetObservation.AddValues(e.Values);
                    Entries = CreateEntries(dataSetObservation.Entries);
                    Count = !Entries.IsNullOrEmpty() ? Entries.Count() : 0;
                }

                // Table Entries
                if (e.Representation == DataItemRepresentation.TABLE)
                {
                    var tableObservation = new EventTableObservation();
                    tableObservation.AddValues(e.Values);
                    Entries = CreateEntries(tableObservation.Entries);
                    Count = !Entries.IsNullOrEmpty() ? Entries.Count() : 0;
                }

                //// DataSet Entries
                //if (e is EventDataSetObservation)
                //{
                //    Entries = CreateEntries(((EventDataSetObservation)e).Entries);
                //    Count = !Entries.IsNullOrEmpty() ? Entries.Count() : 0;
                //}

                //// Table Entries
                //if (e is EventTableObservation)
                //{
                //    Entries = CreateEntries(((EventTableObservation)e).Entries);
                //    Count = !Entries.IsNullOrEmpty() ? Entries.Count() : 0;
                //}
            }
        }

        public EventObservation ToEvent()
        {
            var e = new EventObservation();
            //e.DataItemId = DataItemId;
            //e.Timestamp = Timestamp;
            //e.Name = Name;
            //e.Sequence = Sequence;
            //e.Category = Devices.DataItemCategory.EVENT;
            //e.Type = Type;
            //e.SubType = SubType;
            //e.CompositionId = CompositionId;
            //e.ResetTriggered = ResetTriggered.ConvertEnum<ResetTriggered>();
            ////e.CDATA = CDATA;
            ////e.Entries = Entries;
            //e.Count = Count.HasValue ? Count.Value : 0; ;
            return e;
        }

        public Observation ToObservation()
        {
            var e = new Observation();
            //e.DataItemId = DataItemId;
            //e.Timestamp = Timestamp;
            //e.Name = Name;
            //e.Sequence = Sequence;
            //e.Category = Devices.DataItemCategory.EVENT;
            //e.Type = Type;
            //e.SubType = SubType;
            //e.CompositionId = CompositionId;
            //e.ResetTriggered = ResetTriggered.ConvertEnum<ResetTriggered>();
            //e.CDATA = CDATA;
            //e.Entries = Entries;
            //e.Count = Count.HasValue ? Count.Value : 0; ;
            return e;
        }
    }
}
