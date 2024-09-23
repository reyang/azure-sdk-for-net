// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> This property can be Enabled/Disabled to allow or deny access with the current access keys. Can be updated even after database is created. </summary>
    public readonly partial struct AccessKeysAuthentication : IEquatable<AccessKeysAuthentication>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessKeysAuthentication"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessKeysAuthentication(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static AccessKeysAuthentication Disabled { get; } = new AccessKeysAuthentication(DisabledValue);
        /// <summary> Enabled. </summary>
        public static AccessKeysAuthentication Enabled { get; } = new AccessKeysAuthentication(EnabledValue);
        /// <summary> Determines if two <see cref="AccessKeysAuthentication"/> values are the same. </summary>
        public static bool operator ==(AccessKeysAuthentication left, AccessKeysAuthentication right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessKeysAuthentication"/> values are not the same. </summary>
        public static bool operator !=(AccessKeysAuthentication left, AccessKeysAuthentication right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessKeysAuthentication"/>. </summary>
        public static implicit operator AccessKeysAuthentication(string value) => new AccessKeysAuthentication(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessKeysAuthentication other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessKeysAuthentication other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
