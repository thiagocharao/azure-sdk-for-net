// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    /// <summary>
    /// Data Lake error details information
    /// </summary>
    public partial class ErrorDetails
    {
        private string _code;
        
        /// <summary>
        /// Optional. Gets or sets the HTTP status code or error code
        /// associated with this error
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }
        
        private string _message;
        
        /// <summary>
        /// Optional. Gets or sets the error message localized based on
        /// Accept-Language
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _target;
        
        /// <summary>
        /// Optional. Gets or sets the target of the particular error (for
        /// example, the name of the property in error).
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        public ErrorDetails()
        {
        }
    }
}
