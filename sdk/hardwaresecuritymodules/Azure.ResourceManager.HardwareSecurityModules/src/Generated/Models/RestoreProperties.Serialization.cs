// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class RestoreProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Foldername))
            {
                writer.WritePropertyName("foldername"u8);
                writer.WriteStringValue(Foldername);
            }
            if (Optional.IsDefined(AzureStorageResourceUri))
            {
                writer.WritePropertyName("azureStorageResourceUri"u8);
                writer.WriteStringValue(AzureStorageResourceUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static RestoreProperties DeserializeRestoreProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> foldername = default;
            Optional<Uri> azureStorageResourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("foldername"u8))
                {
                    foldername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageResourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStorageResourceUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new RestoreProperties(foldername.Value, azureStorageResourceUri.Value);
        }
    }
}
