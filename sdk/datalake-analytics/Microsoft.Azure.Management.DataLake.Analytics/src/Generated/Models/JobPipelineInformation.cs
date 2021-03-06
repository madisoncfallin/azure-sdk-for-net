// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job Pipeline Information, showing the relationship of jobs and
    /// recurrences of those jobs in a pipeline.
    /// </summary>
    public partial class JobPipelineInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobPipelineInformation class.
        /// </summary>
        public JobPipelineInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPipelineInformation class.
        /// </summary>
        /// <param name="pipelineId">The job relationship pipeline identifier
        /// (a GUID).</param>
        /// <param name="pipelineName">The friendly name of the job
        /// relationship pipeline, which does not need to be unique.</param>
        /// <param name="pipelineUri">The pipeline uri, unique, links to the
        /// originating service for this pipeline.</param>
        /// <param name="numJobsFailed">The number of jobs in this pipeline
        /// that have failed.</param>
        /// <param name="numJobsCanceled">The number of jobs in this pipeline
        /// that have been canceled.</param>
        /// <param name="numJobsSucceeded">The number of jobs in this pipeline
        /// that have succeeded.</param>
        /// <param name="auHoursFailed">The number of job execution hours that
        /// resulted in failed jobs.</param>
        /// <param name="auHoursCanceled">The number of job execution hours
        /// that resulted in canceled jobs.</param>
        /// <param name="auHoursSucceeded">The number of job execution hours
        /// that resulted in successful jobs.</param>
        /// <param name="lastSubmitTime">The last time a job in this pipeline
        /// was submitted.</param>
        /// <param name="runs">The list of recurrence identifiers representing
        /// each run of this pipeline.</param>
        /// <param name="recurrences">The list of recurrence identifiers
        /// representing each run of this pipeline.</param>
        public JobPipelineInformation(System.Guid? pipelineId = default(System.Guid?), string pipelineName = default(string), string pipelineUri = default(string), int? numJobsFailed = default(int?), int? numJobsCanceled = default(int?), int? numJobsSucceeded = default(int?), double? auHoursFailed = default(double?), double? auHoursCanceled = default(double?), double? auHoursSucceeded = default(double?), System.DateTimeOffset? lastSubmitTime = default(System.DateTimeOffset?), IList<JobPipelineRunInformation> runs = default(IList<JobPipelineRunInformation>), IList<System.Guid?> recurrences = default(IList<System.Guid?>))
        {
            PipelineId = pipelineId;
            PipelineName = pipelineName;
            PipelineUri = pipelineUri;
            NumJobsFailed = numJobsFailed;
            NumJobsCanceled = numJobsCanceled;
            NumJobsSucceeded = numJobsSucceeded;
            AuHoursFailed = auHoursFailed;
            AuHoursCanceled = auHoursCanceled;
            AuHoursSucceeded = auHoursSucceeded;
            LastSubmitTime = lastSubmitTime;
            Runs = runs;
            Recurrences = recurrences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the job relationship pipeline identifier (a GUID).
        /// </summary>
        [JsonProperty(PropertyName = "pipelineId")]
        public System.Guid? PipelineId { get; private set; }

        /// <summary>
        /// Gets the friendly name of the job relationship pipeline, which does
        /// not need to be unique.
        /// </summary>
        [JsonProperty(PropertyName = "pipelineName")]
        public string PipelineName { get; private set; }

        /// <summary>
        /// Gets the pipeline uri, unique, links to the originating service for
        /// this pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "pipelineUri")]
        public string PipelineUri { get; private set; }

        /// <summary>
        /// Gets the number of jobs in this pipeline that have failed.
        /// </summary>
        [JsonProperty(PropertyName = "numJobsFailed")]
        public int? NumJobsFailed { get; private set; }

        /// <summary>
        /// Gets the number of jobs in this pipeline that have been canceled.
        /// </summary>
        [JsonProperty(PropertyName = "numJobsCanceled")]
        public int? NumJobsCanceled { get; private set; }

        /// <summary>
        /// Gets the number of jobs in this pipeline that have succeeded.
        /// </summary>
        [JsonProperty(PropertyName = "numJobsSucceeded")]
        public int? NumJobsSucceeded { get; private set; }

        /// <summary>
        /// Gets the number of job execution hours that resulted in failed
        /// jobs.
        /// </summary>
        [JsonProperty(PropertyName = "auHoursFailed")]
        public double? AuHoursFailed { get; private set; }

        /// <summary>
        /// Gets the number of job execution hours that resulted in canceled
        /// jobs.
        /// </summary>
        [JsonProperty(PropertyName = "auHoursCanceled")]
        public double? AuHoursCanceled { get; private set; }

        /// <summary>
        /// Gets the number of job execution hours that resulted in successful
        /// jobs.
        /// </summary>
        [JsonProperty(PropertyName = "auHoursSucceeded")]
        public double? AuHoursSucceeded { get; private set; }

        /// <summary>
        /// Gets the last time a job in this pipeline was submitted.
        /// </summary>
        [JsonProperty(PropertyName = "lastSubmitTime")]
        public System.DateTimeOffset? LastSubmitTime { get; private set; }

        /// <summary>
        /// Gets the list of recurrence identifiers representing each run of
        /// this pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "runs")]
        public IList<JobPipelineRunInformation> Runs { get; private set; }

        /// <summary>
        /// Gets the list of recurrence identifiers representing each run of
        /// this pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "recurrences")]
        public IList<System.Guid?> Recurrences { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PipelineName != null)
            {
                if (PipelineName.Length > 260)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PipelineName", 260);
                }
            }
        }
    }
}
