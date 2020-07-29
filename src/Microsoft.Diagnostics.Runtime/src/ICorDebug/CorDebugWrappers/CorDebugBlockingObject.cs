// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Diagnostics.Runtime.ICorDebug
{
    public struct CorDebugBlockingObject
    {
        public ICorDebugValue BlockingObject;
        public uint Timeout;
        public CorDebugBlockingReason BlockingReason;
    }
}