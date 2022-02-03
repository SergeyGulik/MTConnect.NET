﻿// Copyright (c) 2022 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace MTConnect.Devices
{
    public struct DataItemValidationResult
    {
        public bool IsValid { get; set; }

        public string Message { get; set; }


        public DataItemValidationResult(bool isValid, string message = null)
        {
            IsValid = isValid;
            Message = message;
        }
    }
}
