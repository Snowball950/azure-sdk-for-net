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
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// A rule metric data source.
    /// </summary>
    public partial class RuleMetricDataSource : RuleDataSource
    {
        private string _metricName;
        
        /// <summary>
        /// Optional. The name of the metric that defines what the rule
        /// monitors.
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }
        
        private string _metricNamespace;
        
        /// <summary>
        /// Optional. Only should be present for availability level metrics,
        /// where the value must be WindowsAzure.Availability.
        /// </summary>
        public string MetricNamespace
        {
            get { return this._metricNamespace; }
            set { this._metricNamespace = value; }
        }
        
        private string _resourceUri;
        
        /// <summary>
        /// Optional. The resource identifier of the resource the rule monitors.
        /// </summary>
        public string ResourceUri
        {
            get { return this._resourceUri; }
            set { this._resourceUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RuleMetricDataSource class.
        /// </summary>
        public RuleMetricDataSource()
        {
        }
    }
}
