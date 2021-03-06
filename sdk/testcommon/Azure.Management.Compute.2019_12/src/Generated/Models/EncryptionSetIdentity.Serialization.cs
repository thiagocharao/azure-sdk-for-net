// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class EncryptionSetIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static EncryptionSetIdentity DeserializeEncryptionSetIdentity(JsonElement element)
        {
            Optional<DiskEncryptionSetIdentityType> type = default;
            Optional<string> principalId = default;
            Optional<string> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new DiskEncryptionSetIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
            }
            return new EncryptionSetIdentity(Optional.ToNullable(type), principalId.Value, tenantId.Value);
        }
    }
}
