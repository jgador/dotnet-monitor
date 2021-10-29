﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Diagnostics.Monitoring.WebApi
{
    internal static class DiagnosticPortOptionsExtensions
    {
        public static DiagnosticPortConnectionMode GetConnectionMode(this DiagnosticPortOptions options)
        {
            return options.ConnectionMode.GetValueOrDefault(DiagnosticPortOptionsDefaults.ConnectionMode);
        }
    }
}