// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncDatabaseIdListResult
    {
        internal static SyncDatabaseIdListResult DeserializeSyncDatabaseIdListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SyncDatabaseIdProperties>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SyncDatabaseIdProperties> array = new List<SyncDatabaseIdProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncDatabaseIdProperties.DeserializeSyncDatabaseIdProperties(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SyncDatabaseIdListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
