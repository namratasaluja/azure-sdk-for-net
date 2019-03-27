// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A credit summary resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CreditSummary : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CreditSummary class.
        /// </summary>
        public CreditSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreditSummary class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="balanceSummary">Summary of balances associated with
        /// this credit summary.</param>
        /// <param name="pendingCreditAdjustments">Pending Credit
        /// Adjustments.</param>
        /// <param name="expiredCredit">Expired Credit.</param>
        /// <param name="pendingEligibleCharges">Pending Eligible
        /// Charges.</param>
        public CreditSummary(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), CreditBalanceSummary balanceSummary = default(CreditBalanceSummary), Amount pendingCreditAdjustments = default(Amount), Amount expiredCredit = default(Amount), Amount pendingEligibleCharges = default(Amount))
            : base(id, name, type, tags)
        {
            BalanceSummary = balanceSummary;
            PendingCreditAdjustments = pendingCreditAdjustments;
            ExpiredCredit = expiredCredit;
            PendingEligibleCharges = pendingEligibleCharges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets summary of balances associated with this credit
        /// summary.
        /// </summary>
        [JsonProperty(PropertyName = "properties.balanceSummary")]
        public CreditBalanceSummary BalanceSummary { get; set; }

        /// <summary>
        /// Gets pending Credit Adjustments.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pendingCreditAdjustments")]
        public Amount PendingCreditAdjustments { get; private set; }

        /// <summary>
        /// Gets expired Credit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiredCredit")]
        public Amount ExpiredCredit { get; private set; }

        /// <summary>
        /// Gets pending Eligible Charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pendingEligibleCharges")]
        public Amount PendingEligibleCharges { get; private set; }

    }
}