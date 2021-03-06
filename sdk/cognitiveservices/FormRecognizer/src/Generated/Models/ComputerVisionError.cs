// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details about the API request error.
    /// </summary>
    public partial class ComputerVisionError
    {
        /// <summary>
        /// Initializes a new instance of the ComputerVisionError class.
        /// </summary>
        public ComputerVisionError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputerVisionError class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">A message explaining the error reported by
        /// the service.</param>
        /// <param name="requestId">A unique request identifier.</param>
        public ComputerVisionError(object code, string message, string requestId = default(string))
        {
            Code = code;
            Message = message;
            RequestId = requestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public object Code { get; set; }

        /// <summary>
        /// Gets or sets a message explaining the error reported by the
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a unique request identifier.
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
