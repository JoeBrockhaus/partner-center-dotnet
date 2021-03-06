﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using GenericOperations;
    using Models;
    using Models.Invoices;

    /// <summary>
    /// Represents the operations that can be done on partner's recon line items.
    /// </summary>
    public interface IReconciliationLineItemCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<InvoiceLineItem, SeekBasedResourceCollection<InvoiceLineItem>>
    {
    }
}