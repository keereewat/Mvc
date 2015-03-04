// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.Internal;
using Microsoft.Framework.Logging;

namespace Microsoft.AspNet.Mvc.Logging
{
    public class ScopeValues : LoggerStructureBase
    {
        public ScopeValues([NotNull] string scopeName)
        {
            ScopeName = scopeName;
        }

        public string ScopeName { get; }

        public override string Format()
        {
            return LogFormatter.FormatLogValues(this);
        }
    }
}