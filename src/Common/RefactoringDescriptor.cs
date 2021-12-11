﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace Roslynator
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public readonly struct RefactoringDescriptor
    {
        public RefactoringDescriptor(string id, string optionKey)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            OptionKey = optionKey ?? throw new ArgumentNullException(nameof(optionKey));
        }

        public string Id { get; }

        public string OptionKey { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"{Id} {OptionKey}";
    }
}
