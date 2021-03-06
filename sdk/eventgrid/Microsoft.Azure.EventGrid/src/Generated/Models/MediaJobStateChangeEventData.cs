// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a
    /// Microsoft.Media.JobStateChange event.
    /// </summary>
    public partial class MediaJobStateChangeEventData
    {
        /// <summary>
        /// Initializes a new instance of the MediaJobStateChangeEventData
        /// class.
        /// </summary>
        public MediaJobStateChangeEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaJobStateChangeEventData
        /// class.
        /// </summary>
        /// <param name="previousState">The previous state of the Job. Possible
        /// values include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="state">The new state of the Job. Possible values
        /// include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="correlationData">Gets the Job correlation
        /// data.</param>
        public MediaJobStateChangeEventData(MediaJobState previousState = default(MediaJobState), MediaJobState state = default(MediaJobState), IDictionary<string, string> correlationData = default(IDictionary<string, string>))
        {
            PreviousState = previousState;
            State = state;
            CorrelationData = correlationData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the previous state of the Job. Possible values include:
        /// 'Canceled', 'Canceling', 'Error', 'Finished', 'Processing',
        /// 'Queued', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "previousState")]
        public MediaJobState PreviousState { get; private set; }

        /// <summary>
        /// Gets the new state of the Job. Possible values include: 'Canceled',
        /// 'Canceling', 'Error', 'Finished', 'Processing', 'Queued',
        /// 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public MediaJobState State { get; private set; }

        /// <summary>
        /// Gets the Job correlation data.
        /// </summary>
        [JsonProperty(PropertyName = "correlationData")]
        public IDictionary<string, string> CorrelationData { get; set; }

    }
}
