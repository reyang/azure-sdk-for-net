// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    public partial class ServiceClassificationOutput : IUtf8JsonSerializable, IJsonModel<ServiceClassificationOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceClassificationOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceClassificationOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceClassificationOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceClassificationOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ServiceClassificationResults))
            {
                writer.WritePropertyName("serviceClassificationResults"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceClassificationResults)
                {
                    writer.WriteObjectValue(item);
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

        ServiceClassificationOutput IJsonModel<ServiceClassificationOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceClassificationOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceClassificationOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceClassificationOutput(document.RootElement, options);
        }

        internal static ServiceClassificationOutput DeserializeServiceClassificationOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ServiceClassificationAnswer> serviceClassificationResults = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceClassificationResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceClassificationAnswer> array = new List<ServiceClassificationAnswer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceClassificationAnswer.DeserializeServiceClassificationAnswer(item, options));
                    }
                    serviceClassificationResults = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceClassificationOutput(serviceClassificationResults ?? new ChangeTrackingList<ServiceClassificationAnswer>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceClassificationOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceClassificationOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceClassificationOutput)} does not support '{options.Format}' format.");
            }
        }

        ServiceClassificationOutput IPersistableModel<ServiceClassificationOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceClassificationOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceClassificationOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceClassificationOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceClassificationOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
