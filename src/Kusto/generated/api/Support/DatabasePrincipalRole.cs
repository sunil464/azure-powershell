// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support
{

    public partial struct DatabasePrincipalRole :
        System.IEquatable<DatabasePrincipalRole>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole Admin = @"Admin";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole Ingestor = @"Ingestor";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole Monitor = @"Monitor";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole UnrestrictedViewers = @"UnrestrictedViewers";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole User = @"User";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole Viewer = @"Viewer";

        /// <summary>the value for an instance of the <see cref="DatabasePrincipalRole" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DatabasePrincipalRole</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DatabasePrincipalRole" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DatabasePrincipalRole(System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DatabasePrincipalRole" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DatabasePrincipalRole(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DatabasePrincipalRole</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DatabasePrincipalRole (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DatabasePrincipalRole && Equals((DatabasePrincipalRole)obj);
        }

        /// <summary>Returns hashCode for enum DatabasePrincipalRole</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DatabasePrincipalRole</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DatabasePrincipalRole</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DatabasePrincipalRole" />.</param>

        public static implicit operator DatabasePrincipalRole(string value)
        {
            return new DatabasePrincipalRole(value);
        }

        /// <summary>Implicit operator to convert DatabasePrincipalRole to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DatabasePrincipalRole" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DatabasePrincipalRole</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DatabasePrincipalRole</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole e2)
        {
            return e2.Equals(e1);
        }
    }
}