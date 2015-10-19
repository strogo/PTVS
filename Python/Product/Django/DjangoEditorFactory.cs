﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Html.Package.Package.Common;

namespace Microsoft.PythonTools.Django {
    [Guid(GuidList.guidDjangoEditorFactoryString)]
    public class DjangoEditorFactory : WebEditorFactory {
        public DjangoEditorFactory(DjangoPackage package)
            : base(package, GuidList.guidDjangoEditorFactory, typeof(DjangoLanguageInfo).GUID) {
        }
    }
}
