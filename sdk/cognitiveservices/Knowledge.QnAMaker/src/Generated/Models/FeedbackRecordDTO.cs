// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Active learning feedback record.
    /// </summary>
    public partial class FeedbackRecordDTO
    {
        /// <summary>
        /// Initializes a new instance of the FeedbackRecordDTO class.
        /// </summary>
        public FeedbackRecordDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeedbackRecordDTO class.
        /// </summary>
        /// <param name="userId">Unique identifier for the user.</param>
        /// <param name="userQuestion">The suggested question being provided as
        /// feedback.</param>
        /// <param name="qnaId">The qnaId for which the suggested question is
        /// provided as feedback.</param>
        public FeedbackRecordDTO(string userId = default(string), string userQuestion = default(string), int? qnaId = default(int?))
        {
            UserId = userId;
            UserQuestion = userQuestion;
            QnaId = qnaId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for the user.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the suggested question being provided as feedback.
        /// </summary>
        [JsonProperty(PropertyName = "userQuestion")]
        public string UserQuestion { get; set; }

        /// <summary>
        /// Gets or sets the qnaId for which the suggested question is provided
        /// as feedback.
        /// </summary>
        [JsonProperty(PropertyName = "qnaId")]
        public int? QnaId { get; set; }

    }
}
