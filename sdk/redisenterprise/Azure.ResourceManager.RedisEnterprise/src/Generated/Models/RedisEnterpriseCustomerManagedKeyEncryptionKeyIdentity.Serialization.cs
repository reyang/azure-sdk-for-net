// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity : IUtf8JsonSerializable, IJsonModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentityResourceId))
            {
                writer.WritePropertyName("userAssignedIdentityResourceId"u8);
                writer.WriteStringValue(UserAssignedIdentityResourceId);
            }
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("identityType"u8);
                writer.WriteStringValue(IdentityType.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity IJsonModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(document.RootElement, options);
        }

        internal static RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier userAssignedIdentityResourceId = default;
            RedisEnterpriseCustomerManagedKeyIdentityType? identityType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentityResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentityResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityType = new RedisEnterpriseCustomerManagedKeyIdentityType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(userAssignedIdentityResourceId, identityType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserAssignedIdentityResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userAssignedIdentityResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserAssignedIdentityResourceId))
                {
                    builder.Append("  userAssignedIdentityResourceId: ");
                    builder.AppendLine($"'{UserAssignedIdentityResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdentityType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  identityType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IdentityType))
                {
                    builder.Append("  identityType: ");
                    builder.AppendLine($"'{IdentityType.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity)} does not support writing '{options.Format}' format.");
            }
        }

        RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
