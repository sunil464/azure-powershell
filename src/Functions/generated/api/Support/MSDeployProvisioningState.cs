// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    public partial struct MSDeployProvisioningState :
        System.IEquatable<MSDeployProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState Accepted = @"accepted";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState Canceled = @"canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState Failed = @"failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState Running = @"running";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState Succeeded = @"succeeded";

        /// <summary>the value for an instance of the <see cref="MSDeployProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MSDeployProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MSDeployProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MSDeployProvisioningState(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MSDeployProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MSDeployProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MSDeployProvisioningState && Equals((MSDeployProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum MSDeployProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MSDeployProvisioningState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MSDeployProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MSDeployProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MSDeployProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MSDeployProvisioningState" />.</param>

        public static implicit operator MSDeployProvisioningState(string value)
        {
            return new MSDeployProvisioningState(value);
        }

        /// <summary>Implicit operator to convert MSDeployProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MSDeployProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MSDeployProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MSDeployProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MSDeployProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}