// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>An object that represents an export pipeline for a container registry.</summary>
    public partial class ExportPipeline :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipeline,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ProxyResource();

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityProperties _identity;

        /// <summary>The identity of the export pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityProperties Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IdentityProperties()); set => this._identity = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).TenantId = value ?? null; }

        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ResourceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ResourceIdentityType)""); }

        /// <summary>
        /// The list of user identities associated with the resource. The user identity
        /// dictionary key references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
        /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location of the export pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Type = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IdentityProperties()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ExportPipelineProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Target</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineTargetProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).Target = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Name; }

        /// <summary>The list of all options configured for the pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineOptions[] Option { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).Option; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).Option = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineProperties _property;

        /// <summary>The properties of the export pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ExportPipelineProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the pipeline at the time the operation was called.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource modification (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LastModifiedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LastModifiedByType)""); }

        /// <summary>They key vault secret uri to obtain the target storage SAS token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).TargetKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).TargetKeyVaultUri = value ?? null; }

        /// <summary>The type of target for the export pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).TargetType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).TargetType = value ?? null; }

        /// <summary>
        /// The target uri of the export pipeline.
        /// When 'AzureStorageBlob': "https://accountName.blob.core.windows.net/containerName/blobName"
        /// When 'AzureStorageBlobContainer': "https://accountName.blob.core.windows.net/containerName"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).TargetUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelinePropertiesInternal)Property).TargetUri = value ?? null; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="ExportPipeline" /> instance.</summary>
        public ExportPipeline()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// An object that represents an export pipeline for a container registry.
    public partial interface IExportPipeline :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get; set; }
        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity
        /// dictionary key references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
        /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of user identities associated with the resource. The user identity
        dictionary key references will be ARM resource ids in the form:
        '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
            providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>The location of the export pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the export pipeline.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The list of all options configured for the pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of all options configured for the pipeline.",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineOptions) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineOptions[] Option { get; set; }
        /// <summary>The provisioning state of the pipeline at the time the operation was called.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the pipeline at the time the operation was called.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>They key vault secret uri to obtain the target storage SAS token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"They key vault secret uri to obtain the target storage SAS token.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string TargetKeyVaultUri { get; set; }
        /// <summary>The type of target for the export pipeline.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of target for the export pipeline.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string TargetType { get; set; }
        /// <summary>
        /// The target uri of the export pipeline.
        /// When 'AzureStorageBlob': "https://accountName.blob.core.windows.net/containerName/blobName"
        /// When 'AzureStorageBlobContainer': "https://accountName.blob.core.windows.net/containerName"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target uri of the export pipeline.
        When 'AzureStorageBlob': ""https://accountName.blob.core.windows.net/containerName/blobName""
        When 'AzureStorageBlobContainer':  ""https://accountName.blob.core.windows.net/containerName""",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string TargetUri { get; set; }

    }
    /// An object that represents an export pipeline for a container registry.
    internal partial interface IExportPipelineInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IProxyResourceInternal
    {
        string AzureAsyncOperation { get; set; }
        /// <summary>The identity of the export pipeline.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityProperties Identity { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string IdentityTenantId { get; set; }
        /// <summary>The identity type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity
        /// dictionary key references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
        /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IIdentityPropertiesUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>The location of the export pipeline.</summary>
        string Location { get; set; }
        /// <summary>The list of all options configured for the pipeline.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.PipelineOptions[] Option { get; set; }
        /// <summary>The properties of the export pipeline.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineProperties Property { get; set; }
        /// <summary>The provisioning state of the pipeline at the time the operation was called.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The target properties of the export pipeline.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IExportPipelineTargetProperties Target { get; set; }
        /// <summary>They key vault secret uri to obtain the target storage SAS token.</summary>
        string TargetKeyVaultUri { get; set; }
        /// <summary>The type of target for the export pipeline.</summary>
        string TargetType { get; set; }
        /// <summary>
        /// The target uri of the export pipeline.
        /// When 'AzureStorageBlob': "https://accountName.blob.core.windows.net/containerName/blobName"
        /// When 'AzureStorageBlobContainer': "https://accountName.blob.core.windows.net/containerName"
        /// </summary>
        string TargetUri { get; set; }

    }
}