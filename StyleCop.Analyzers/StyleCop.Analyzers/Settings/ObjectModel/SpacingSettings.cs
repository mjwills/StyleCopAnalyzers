﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Settings.ObjectModel
{
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization.OptIn)]
    internal class SpacingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpacingSettings"/> class during JSON deserialization.
        /// </summary>
        [JsonConstructor]
        protected internal SpacingSettings()
        {
        }
    }
}
