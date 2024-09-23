// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseDatabaseGeoReplication : IUtf8JsonSerializable, IJsonModel<RedisEnterpriseDatabaseGeoReplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisEnterpriseDatabaseGeoReplication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RedisEnterpriseDatabaseGeoReplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseGeoReplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseGeoReplication)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(GroupNickname))
            {
                writer.WritePropertyName("groupNickname"u8);
                writer.WriteStringValue(GroupNickname);
            }
            if (Optional.IsCollectionDefined(LinkedDatabases))
            {
                writer.WritePropertyName("linkedDatabases"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedDatabases)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        RedisEnterpriseDatabaseGeoReplication IJsonModel<RedisEnterpriseDatabaseGeoReplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseGeoReplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseGeoReplication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseDatabaseGeoReplication(document.RootElement, options);
        }

        internal static RedisEnterpriseDatabaseGeoReplication DeserializeRedisEnterpriseDatabaseGeoReplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string groupNickname = default;
            IList<RedisEnterpriseLinkedDatabase> linkedDatabases = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupNickname"u8))
                {
                    groupNickname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedDatabases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RedisEnterpriseLinkedDatabase> array = new List<RedisEnterpriseLinkedDatabase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RedisEnterpriseLinkedDatabase.DeserializeRedisEnterpriseLinkedDatabase(item, options));
                    }
                    linkedDatabases = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RedisEnterpriseDatabaseGeoReplication(groupNickname, linkedDatabases ?? new ChangeTrackingList<RedisEnterpriseLinkedDatabase>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GroupNickname), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  groupNickname: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GroupNickname))
                {
                    builder.Append("  groupNickname: ");
                    if (GroupNickname.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GroupNickname}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GroupNickname}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LinkedDatabases), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  linkedDatabases: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(LinkedDatabases))
                {
                    if (LinkedDatabases.Any())
                    {
                        builder.Append("  linkedDatabases: ");
                        builder.AppendLine("[");
                        foreach (var item in LinkedDatabases)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  linkedDatabases: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RedisEnterpriseDatabaseGeoReplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseGeoReplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseGeoReplication)} does not support writing '{options.Format}' format.");
            }
        }

        RedisEnterpriseDatabaseGeoReplication IPersistableModel<RedisEnterpriseDatabaseGeoReplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseGeoReplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisEnterpriseDatabaseGeoReplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseGeoReplication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisEnterpriseDatabaseGeoReplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
