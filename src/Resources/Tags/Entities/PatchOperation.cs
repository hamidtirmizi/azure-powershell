﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Collections;
using Newtonsoft.Json;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Entities.Resources
{
    /// <summary>
    /// The patch operation values supported.
    /// </summary>
    public enum PatchOperation
    {
        /// <summary>
        /// Default value
        /// </summary>
        NotSpecified,

        /// <summary>
        /// Replaces the properties on the resource with the properties in the request payload.
        /// </summary>
        Replace,

        /// <summary>
        /// Merges the properties on the resource with the properties in the request payload.
        /// </summary>
        Merge,

        /// <summary>
        /// Deletes the properties on the resource which are specified in the request payload.
        /// </summary>
        Delete
    }
}

