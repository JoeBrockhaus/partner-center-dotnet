﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    using System;

    /// <summary>
    /// The subscription provisioning status details.
    /// </summary>
    public sealed class SubscriptionProvisioningStatus : ResourceBase
    {
        /// <summary>
        /// Gets or sets the end  date.
        /// </summary>
        /// <remarks>
        /// Renewal or end date after provisioning.
        /// </remarks>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <remarks>
        /// Latest Seat number or subscription quantity after provisioning.
        /// </remarks>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the subscription SKU identifier.
        /// </summary>
        public Guid SkuId { get; set; }

        /// <summary>Gets or sets the subscription provisioning status.</summary>
        public ProvisioningStatus Status { get; set; }
    }
}