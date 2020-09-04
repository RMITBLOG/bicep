// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ServiceBus_2015_08_01
    {
        private const string ProviderNamespace = "Microsoft.ServiceBus";
        private const string ApiVersion = "2015-08-01";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_AuthorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "AuthorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_queues = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "queues"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_topics = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "topics"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_queues_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "queues", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_topics_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "topics", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_topics_subscriptions = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "topics", "subscriptions"}, ApiVersion);
        private static Lazy<Microsoft_ServiceBus_2015_08_01> InstanceLazy = new Lazy<Microsoft_ServiceBus_2015_08_01>(() => new Microsoft_ServiceBus_2015_08_01());
        private Microsoft_ServiceBus_2015_08_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Basic'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.None), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Basic'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.Required), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            NamespaceProperties = new NamedObjectType("NamespaceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Created'"), new StringLiteralType("'Activating'"), new StringLiteralType("'Enabling'"), new StringLiteralType("'Active'"), new StringLiteralType("'Disabling'"), new StringLiteralType("'Disabled'"), new StringLiteralType("'SoftDeleting'"), new StringLiteralType("'SoftDeleted'"), new StringLiteralType("'Removing'"), new StringLiteralType("'Removed'"), new StringLiteralType("'Failed'")), TypePropertyFlags.None), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("updatedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("serviceBusEndpoint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("createACSNamespace", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            SharedAccessAuthorizationRuleProperties = new NamedObjectType("SharedAccessAuthorizationRuleProperties", new ITypeProperty[]{new TypeProperty("rights", new TypedArrayType(UnionType.Create(new StringLiteralType("'Manage'"), new StringLiteralType("'Send'"), new StringLiteralType("'Listen'"))), TypePropertyFlags.Required)}, null);
            QueueProperties = new NamedObjectType("QueueProperties", new ITypeProperty[]{new TypeProperty("lockDuration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("accessedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("autoDeleteOnIdle", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("entityAvailabilityStatus", UnionType.Create(new StringLiteralType("'Available'"), new StringLiteralType("'Limited'"), new StringLiteralType("'Renaming'"), new StringLiteralType("'Restoring'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.None), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("defaultMessageTimeToLive", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("duplicateDetectionHistoryTimeWindow", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enableBatchedOperations", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("deadLetteringOnMessageExpiration", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableExpress", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enablePartitioning", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isAnonymousAccessible", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("maxDeliveryCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxSizeInMegabytes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("messageCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new LazyTypeProperty("countDetails", () => MessageCountDetails, TypePropertyFlags.ReadOnly), new TypeProperty("requiresDuplicateDetection", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("requiresSession", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("sizeInBytes", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Active'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Disabled'"), new StringLiteralType("'ReceiveDisabled'"), new StringLiteralType("'Renaming'"), new StringLiteralType("'Restoring'"), new StringLiteralType("'SendDisabled'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.None), new TypeProperty("supportOrdering", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("updatedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            MessageCountDetails = new NamedObjectType("MessageCountDetails", new ITypeProperty[]{new TypeProperty("activeMessageCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("deadLetterMessageCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("scheduledMessageCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("transferDeadLetterMessageCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("transferMessageCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly)}, null);
            TopicProperties = new NamedObjectType("TopicProperties", new ITypeProperty[]{new TypeProperty("accessedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("autoDeleteOnIdle", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("entityAvailabilityStatus", UnionType.Create(new StringLiteralType("'Available'"), new StringLiteralType("'Limited'"), new StringLiteralType("'Renaming'"), new StringLiteralType("'Restoring'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.None), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("countDetails", () => MessageCountDetails, TypePropertyFlags.ReadOnly), new TypeProperty("defaultMessageTimeToLive", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("duplicateDetectionHistoryTimeWindow", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enableBatchedOperations", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableExpress", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enablePartitioning", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("filteringMessagesBeforePublishing", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isAnonymousAccessible", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isExpress", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("maxSizeInMegabytes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("requiresDuplicateDetection", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("sizeInBytes", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Active'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Disabled'"), new StringLiteralType("'ReceiveDisabled'"), new StringLiteralType("'Renaming'"), new StringLiteralType("'Restoring'"), new StringLiteralType("'SendDisabled'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.None), new TypeProperty("subscriptionCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("supportOrdering", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("updatedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            SubscriptionProperties = new NamedObjectType("SubscriptionProperties", new ITypeProperty[]{new TypeProperty("accessedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("autoDeleteOnIdle", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("countDetails", () => MessageCountDetails, TypePropertyFlags.ReadOnly), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("defaultMessageTimeToLive", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("deadLetteringOnFilterEvaluationExceptions", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("deadLetteringOnMessageExpiration", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableBatchedOperations", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("entityAvailabilityStatus", UnionType.Create(new StringLiteralType("'Available'"), new StringLiteralType("'Limited'"), new StringLiteralType("'Renaming'"), new StringLiteralType("'Restoring'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.None), new TypeProperty("isReadOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("lockDuration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxDeliveryCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("messageCount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("requiresSession", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Active'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Disabled'"), new StringLiteralType("'ReceiveDisabled'"), new StringLiteralType("'Renaming'"), new StringLiteralType("'Restoring'"), new StringLiteralType("'SendDisabled'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.None), new TypeProperty("updatedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_namespaces = new ResourceType("Microsoft.ServiceBus/namespaces", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => NamespaceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_AuthorizationRules = new ResourceType("Microsoft.ServiceBus/namespaces/AuthorizationRules", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SharedAccessAuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/AuthorizationRules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_AuthorizationRules);
            ResourceType_namespaces_queues = new ResourceType("Microsoft.ServiceBus/namespaces/queues", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => QueueProperties, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/queues'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_queues);
            ResourceType_namespaces_topics = new ResourceType("Microsoft.ServiceBus/namespaces/topics", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => TopicProperties, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/topics'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_topics);
            ResourceType_namespaces_queues_authorizationRules = new ResourceType("Microsoft.ServiceBus/namespaces/queues/authorizationRules", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SharedAccessAuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/queues/authorizationRules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_queues_authorizationRules);
            ResourceType_namespaces_topics_authorizationRules = new ResourceType("Microsoft.ServiceBus/namespaces/topics/authorizationRules", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SharedAccessAuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/topics/authorizationRules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_topics_authorizationRules);
            ResourceType_namespaces_topics_subscriptions = new ResourceType("Microsoft.ServiceBus/namespaces/topics/subscriptions", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/topics/subscriptions'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => SubscriptionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_topics_subscriptions);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces, () => InstanceLazy.Value.ResourceType_namespaces);
            registrar.RegisterType(ResourceTypeReference_namespaces_AuthorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_AuthorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_queues, () => InstanceLazy.Value.ResourceType_namespaces_queues);
            registrar.RegisterType(ResourceTypeReference_namespaces_topics, () => InstanceLazy.Value.ResourceType_namespaces_topics);
            registrar.RegisterType(ResourceTypeReference_namespaces_queues_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_queues_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_topics_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_topics_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_topics_subscriptions, () => InstanceLazy.Value.ResourceType_namespaces_topics_subscriptions);
        }
        private readonly ResourceType ResourceType_namespaces;
        private readonly ResourceType ResourceType_namespaces_AuthorizationRules;
        private readonly ResourceType ResourceType_namespaces_queues;
        private readonly ResourceType ResourceType_namespaces_topics;
        private readonly ResourceType ResourceType_namespaces_queues_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_topics_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_topics_subscriptions;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol NamespaceProperties;
        private readonly TypeSymbol SharedAccessAuthorizationRuleProperties;
        private readonly TypeSymbol QueueProperties;
        private readonly TypeSymbol MessageCountDetails;
        private readonly TypeSymbol TopicProperties;
        private readonly TypeSymbol SubscriptionProperties;
    }
}