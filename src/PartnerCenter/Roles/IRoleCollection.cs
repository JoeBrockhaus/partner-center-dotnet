﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    using GenericOperations;
    using Models;
    using Models.Roles;

    /// <summary>
    /// Represents the available operations for roles.
    /// </summary>
    public interface IRoleCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<Role, SeekBasedResourceCollection<Role>>, IEntitySelector<string, IRole>
    {
    }
}