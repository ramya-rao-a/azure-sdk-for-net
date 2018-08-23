// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies details of the jobs to be created on a schedule.
    /// </summary>
    public partial class JobSpecification
    {
        /// <summary>
        /// Initializes a new instance of the JobSpecification class.
        /// </summary>
        public JobSpecification()
        {
            PoolInfo = new PoolInformation();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobSpecification class.
        /// </summary>
        /// <param name="poolInfo">The pool on which the Batch service runs the
        /// tasks of jobs created under this schedule.</param>
        /// <param name="priority">The priority of jobs created under this
        /// schedule.</param>
        /// <param name="displayName">The display name for jobs created under
        /// this schedule.</param>
        /// <param name="usesTaskDependencies">Whether tasks in the job can
        /// define dependencies on each other. The default is false.</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all tasks in a job created under this schedule are
        /// in the completed state.</param>
        /// <param name="onTaskFailure">The action the Batch service should
        /// take when any task fails in a job created under this schedule. A
        /// task is considered to have failed if it have failed if has a
        /// failureInfo. A failureInfo is set if the task completes with a
        /// non-zero exit code after exhausting its retry count, or if there
        /// was an error starting the task, for example due to a resource file
        /// download error.</param>
        /// <param name="constraints">The execution constraints for jobs
        /// created under this schedule.</param>
        /// <param name="jobManagerTask">The details of a Job Manager task to
        /// be launched when a job is started under this schedule.</param>
        /// <param name="jobPreparationTask">The Job Preparation task for jobs
        /// created under this schedule.</param>
        /// <param name="jobReleaseTask">The Job Release task for jobs created
        /// under this schedule.</param>
        /// <param name="commonEnvironmentSettings">A list of common
        /// environment variable settings. These environment variables are set
        /// for all tasks in jobs created under this schedule (including the
        /// Job Manager, Job Preparation and Job Release tasks).</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// each job created under this schedule as metadata.</param>
        public JobSpecification(PoolInformation poolInfo, int? priority = default(int?), string displayName = default(string), bool? usesTaskDependencies = default(bool?), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), OnTaskFailure? onTaskFailure = default(OnTaskFailure?), JobConstraints constraints = default(JobConstraints), JobManagerTask jobManagerTask = default(JobManagerTask), JobPreparationTask jobPreparationTask = default(JobPreparationTask), JobReleaseTask jobReleaseTask = default(JobReleaseTask), IList<EnvironmentSetting> commonEnvironmentSettings = default(IList<EnvironmentSetting>), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Priority = priority;
            DisplayName = displayName;
            UsesTaskDependencies = usesTaskDependencies;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the priority of jobs created under this schedule.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. The default
        /// value is 0. This priority is used as the default for all jobs under
        /// the job schedule. You can update a job's priority after it has been
        /// created using by using the update job API.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the display name for jobs created under this schedule.
        /// </summary>
        /// <remarks>
        /// The name need not be unique and can contain any Unicode characters
        /// up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets whether tasks in the job can define dependencies on
        /// each other. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "usesTaskDependencies")]
        public bool? UsesTaskDependencies { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// tasks in a job created under this schedule are in the completed
        /// state.
        /// </summary>
        /// <remarks>
        /// Note that if a job contains no tasks, then all tasks are considered
        /// complete. This option is therefore most commonly used with a Job
        /// Manager task; if you want to use automatic job termination without
        /// a Job Manager, you should initially set onAllTasksComplete to
        /// noaction and update the job properties to set onAllTasksComplete to
        /// terminatejob once you have finished adding tasks. The default is
        /// noaction. Possible values include: 'noAction', 'terminateJob'
        /// </remarks>
        [JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when any task
        /// fails in a job created under this schedule. A task is considered to
        /// have failed if it have failed if has a failureInfo. A failureInfo
        /// is set if the task completes with a non-zero exit code after
        /// exhausting its retry count, or if there was an error starting the
        /// task, for example due to a resource file download error.
        /// </summary>
        /// <remarks>
        /// The default is noaction. Possible values include: 'noAction',
        /// 'performExitOptionsJobAction'
        /// </remarks>
        [JsonProperty(PropertyName = "onTaskFailure")]
        public OnTaskFailure? OnTaskFailure { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for jobs created under this
        /// schedule.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the details of a Job Manager task to be launched when
        /// a job is started under this schedule.
        /// </summary>
        /// <remarks>
        /// If the job does not specify a Job Manager task, the user must
        /// explicitly add tasks to the job using the Task API. If the job does
        /// specify a Job Manager task, the Batch service creates the Job
        /// Manager task when the job is created, and will try to schedule the
        /// Job Manager task before scheduling other tasks in the job.
        /// </remarks>
        [JsonProperty(PropertyName = "jobManagerTask")]
        public JobManagerTask JobManagerTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Preparation task for jobs created under this
        /// schedule.
        /// </summary>
        /// <remarks>
        /// If a job has a Job Preparation task, the Batch service will run the
        /// Job Preparation task on a compute node before starting any tasks of
        /// that job on that compute node.
        /// </remarks>
        [JsonProperty(PropertyName = "jobPreparationTask")]
        public JobPreparationTask JobPreparationTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Release task for jobs created under this
        /// schedule.
        /// </summary>
        /// <remarks>
        /// The primary purpose of the Job Release task is to undo changes to
        /// compute nodes made by the Job Preparation task. Example activities
        /// include deleting local files, or shutting down services that were
        /// started as part of job preparation. A Job Release task cannot be
        /// specified without also specifying a Job Preparation task for the
        /// job. The Batch service runs the Job Release task on the compute
        /// nodes that have run the Job Preparation task.
        /// </remarks>
        [JsonProperty(PropertyName = "jobReleaseTask")]
        public JobReleaseTask JobReleaseTask { get; set; }

        /// <summary>
        /// Gets or sets a list of common environment variable settings. These
        /// environment variables are set for all tasks in jobs created under
        /// this schedule (including the Job Manager, Job Preparation and Job
        /// Release tasks).
        /// </summary>
        /// <remarks>
        /// Individual tasks can override an environment setting specified here
        /// by specifying the same setting name with a different value.
        /// </remarks>
        [JsonProperty(PropertyName = "commonEnvironmentSettings")]
        public IList<EnvironmentSetting> CommonEnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the tasks of
        /// jobs created under this schedule.
        /// </summary>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with each job
        /// created under this schedule as metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

    }
}
