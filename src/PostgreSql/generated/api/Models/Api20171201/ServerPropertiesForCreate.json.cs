namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>The properties used to create a new server.</summary>
    public partial class ServerPropertiesForCreate
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate.
        /// Note: the Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate interface is polymorphic,
        /// and the precise model class that will get deserialized is determined at runtime based on the payload.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode node)
        {
            if (!(node is Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json))
            {
                return null;
            }
            // Polymorphic type -- select the appropriate constructor using the discriminator

            switch ( json.StringProperty("createMode") )
            {
                case "Default":
                {
                    return new ServerPropertiesForDefaultCreate(json);
                }
                case "PointInTimeRestore":
                {
                    return new ServerPropertiesForRestore(json);
                }
                case "GeoRestore":
                {
                    return new ServerPropertiesForGeoRestore(json);
                }
                case "Replica":
                {
                    return new ServerPropertiesForReplica(json);
                }
            }
            return new ServerPropertiesForCreate(json);
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject into a new instance of <see cref="ServerPropertiesForCreate" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServerPropertiesForCreate(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_storageProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject>("storageProfile"), out var __jsonStorageProfile) ? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.StorageProfile.FromJson(__jsonStorageProfile) : StorageProfile;}
            {_createMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("createMode"), out var __jsonCreateMode) ? (string)__jsonCreateMode : (string)CreateMode;}
            {_infrastructureEncryption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("infrastructureEncryption"), out var __jsonInfrastructureEncryption) ? (string)__jsonInfrastructureEncryption : (string)InfrastructureEncryption;}
            {_minimalTlsVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("minimalTlsVersion"), out var __jsonMinimalTlsVersion) ? (string)__jsonMinimalTlsVersion : (string)MinimalTlsVersion;}
            {_publicNetworkAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("publicNetworkAccess"), out var __jsonPublicNetworkAccess) ? (string)__jsonPublicNetworkAccess : (string)PublicNetworkAccess;}
            {_sslEnforcement = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("sslEnforcement"), out var __jsonSslEnforcement) ? (string)__jsonSslEnforcement : (string)SslEnforcement;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServerPropertiesForCreate" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServerPropertiesForCreate" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._storageProfile ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) this._storageProfile.ToJson(null,serializationMode) : null, "storageProfile" ,container.Add );
            AddIf( null != (((object)this._createMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._createMode.ToString()) : null, "createMode" ,container.Add );
            AddIf( null != (((object)this._infrastructureEncryption)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._infrastructureEncryption.ToString()) : null, "infrastructureEncryption" ,container.Add );
            AddIf( null != (((object)this._minimalTlsVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._minimalTlsVersion.ToString()) : null, "minimalTlsVersion" ,container.Add );
            AddIf( null != (((object)this._publicNetworkAccess)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._publicNetworkAccess.ToString()) : null, "publicNetworkAccess" ,container.Add );
            AddIf( null != (((object)this._sslEnforcement)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._sslEnforcement.ToString()) : null, "sslEnforcement" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}