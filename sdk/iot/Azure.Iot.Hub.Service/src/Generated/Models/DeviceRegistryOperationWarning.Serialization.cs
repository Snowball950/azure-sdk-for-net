// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class DeviceRegistryOperationWarning
    {
        internal static DeviceRegistryOperationWarning DeserializeDeviceRegistryOperationWarning(JsonElement element)
        {
            Optional<string> deviceId = default;
            Optional<string> warningCode = default;
            Optional<string> warningStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warningCode"))
                {
                    warningCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warningStatus"))
                {
                    warningStatus = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceRegistryOperationWarning(deviceId.Value, warningCode.Value, warningStatus.Value);
        }
    }
}
