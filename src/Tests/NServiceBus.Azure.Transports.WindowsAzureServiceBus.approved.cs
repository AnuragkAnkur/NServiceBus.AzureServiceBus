﻿[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"NServiceBus.AzureServiceBus.AcceptanceTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100db5719402b853e11b7a2141f51a4d1a6741ac3db3c7ef6ae1eb294151615b72b7993460451a4a75c14f66831b86b4560f7d875c15f20f4e8a5fe591b1fd49f3a67ce8bf14a0fc7fb42f29927b941d584e82ec41d0868965f2455973844776e4ff9e24d87b81253570dde6c907e55dc191dfbf4951d512165fa02a314917acec0")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"NServiceBus.AzureServiceBus.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100dde965e6172e019ac82c2639ffe494dd2e7dd16347c34762a05732b492e110f2e4e2e1b5ef2d85c848ccfb671ee20a47c8d1376276708dc30a90ff1121b647ba3b7259a6bc383b2034938ef0e275b58b920375ac605076178123693c6c4f1331661a62eba28c249386855637780e3ff5f23a6d854700eaa6803ef48907513b92")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5.2", FrameworkDisplayName=".NET Framework 4.5.2")]

namespace NServiceBus
{
    
    public class AzureServiceBusCompositionExtensionPoint<T> : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
        where T : NServiceBus.Transport.AzureServiceBus.ICompositionStrategy { }
    public class AzureServiceBusCompositionSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusCompositionExtensionPoint<T> UseStrategy<T>()
            where T : NServiceBus.Transport.AzureServiceBus.ICompositionStrategy { }
    }
    public class static AzureServiceBusDiscriminatorBasedIndividualizationSettingsExtensions
    {
        public static NServiceBus.AzureServiceBusIndividualizationExtensionPoint<NServiceBus.DiscriminatorBasedIndividualization> DiscriminatorGenerator(this NServiceBus.AzureServiceBusIndividualizationExtensionPoint<NServiceBus.DiscriminatorBasedIndividualization> individualizationStrategy, System.Func<string, string> discriminatorGenerator) { }
    }
    public class AzureServiceBusEndpointOrientedTopologySettings : NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> { }
    public class static AzureServiceBusEndpointOrientedTopologySettingsExtensions
    {
        public static NServiceBus.AzureServiceBusEndpointOrientedTopologySettings RegisterPublisher(this NServiceBus.AzureServiceBusEndpointOrientedTopologySettings topologySettings, System.Type type, string publisherName) { }
        public static NServiceBus.AzureServiceBusEndpointOrientedTopologySettings RegisterPublisher(this NServiceBus.AzureServiceBusEndpointOrientedTopologySettings topologySettings, System.Reflection.Assembly assembly, string publisherName) { }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusTopologySettings<NServiceBus.EndpointOrientedTopology> RegisterPublisher(this NServiceBus.AzureServiceBusTopologySettings<NServiceBus.EndpointOrientedTopology> topologySettings, System.Type type, string publisherName) { }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusTopologySettings<NServiceBus.EndpointOrientedTopology> RegisterPublisher(this NServiceBus.AzureServiceBusTopologySettings<NServiceBus.EndpointOrientedTopology> topologySettings, System.Reflection.Assembly assembly, string publisherName) { }
    }
    public class AzureServiceBusForwardingTopologySettings : NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class static AzureServiceBusForwardingTopologySettingsExtensions
    {
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusTopologySettings<NServiceBus.ForwardingTopology> BundlePrefix(this NServiceBus.AzureServiceBusTopologySettings<NServiceBus.ForwardingTopology> topologySettings, string prefix) { }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusForwardingTopologySettings BundlePrefix(this NServiceBus.AzureServiceBusForwardingTopologySettings topologySettings, string prefix) { }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusTopologySettings<NServiceBus.ForwardingTopology> NumberOfEntitiesInBundle(this NServiceBus.AzureServiceBusTopologySettings<NServiceBus.ForwardingTopology> topologySettings, int number) { }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusForwardingTopologySettings NumberOfEntitiesInBundle(this NServiceBus.AzureServiceBusForwardingTopologySettings topologySettings, int number) { }
    }
    public class static AzureServiceBusHierarchyCompositionSettingsExtensions
    {
        public static NServiceBus.AzureServiceBusCompositionExtensionPoint<NServiceBus.HierarchyComposition> PathGenerator(this NServiceBus.AzureServiceBusCompositionExtensionPoint<NServiceBus.HierarchyComposition> composition, System.Func<string, string> pathGenerator) { }
    }
    public class AzureServiceBusIndividualizationExtensionPoint<T> : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
        where T : NServiceBus.Transport.AzureServiceBus.IIndividualizationStrategy { }
    public class AzureServiceBusIndividualizationSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusIndividualizationExtensionPoint<T> UseStrategy<T>()
            where T : NServiceBus.Transport.AzureServiceBus.IIndividualizationStrategy { }
    }
    public class AzureServiceBusMessageReceiverSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusMessageReceiverSettings AutoRenewTimeout(System.TimeSpan autoRenewTimeout) { }
        public NServiceBus.AzureServiceBusMessageReceiverSettings PrefetchCount(int prefetchCount) { }
        public NServiceBus.AzureServiceBusMessageReceiverSettings ReceiveMode(Microsoft.ServiceBus.Messaging.ReceiveMode receiveMode) { }
        public NServiceBus.AzureServiceBusMessageReceiverSettings RetryPolicy(Microsoft.ServiceBus.RetryPolicy retryPolicy) { }
    }
    public class AzureServiceBusMessageSenderSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusMessageSenderSettings BackOffTimeOnThrottle(System.TimeSpan backoffTime) { }
        public NServiceBus.AzureServiceBusMessageSenderSettings MaximuMessageSizeInKilobytes(int sizeInKilobytes) { }
        public NServiceBus.AzureServiceBusMessageSenderSettings MessageSizePaddingPercentage(int percentage) { }
        public NServiceBus.AzureServiceBusMessageSenderSettings OversizedBrokeredMessageHandler(NServiceBus.Transport.AzureServiceBus.IHandleOversizedBrokeredMessages instance) { }
        public NServiceBus.AzureServiceBusMessageSenderSettings RetryAttemptsOnThrottle(int count) { }
        public NServiceBus.AzureServiceBusMessageSenderSettings RetryPolicy(Microsoft.ServiceBus.RetryPolicy retryPolicy) { }
    }
    public class AzureServiceBusMessagingFactoriesSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusMessagingFactoriesSettings BatchFlushInterval(System.TimeSpan batchFlushInterval) { }
        public NServiceBus.AzureServiceBusMessagingFactoriesSettings MessagingFactorySettingsFactory(System.Func<string, Microsoft.ServiceBus.Messaging.MessagingFactorySettings> factory) { }
        public NServiceBus.AzureServiceBusMessagingFactoriesSettings NumberOfMessagingFactoriesPerNamespace(int number) { }
        public NServiceBus.AzureServiceBusMessagingFactoriesSettings RetryPolicy(Microsoft.ServiceBus.RetryPolicy retryPolicy) { }
    }
    public class AzureServiceBusNamespaceManagersSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusNamespaceManagersSettings NamespaceManagerSettingsFactory(System.Func<string, Microsoft.ServiceBus.NamespaceManagerSettings> factory) { }
        public NServiceBus.AzureServiceBusNamespaceManagersSettings RetryPolicy(Microsoft.ServiceBus.RetryPolicy retryPolicy) { }
        public NServiceBus.AzureServiceBusNamespaceManagersSettings TokenProvider(System.Func<string, Microsoft.ServiceBus.TokenProvider> factory) { }
    }
    public class AzureServiceBusNamespacePartitioningSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public void AddNamespace(string name, string connectionString) { }
        public NServiceBus.AzureServiceBusNamespacePartitioningSettings UseStrategy<T>()
            where T : NServiceBus.Transport.AzureServiceBus.INamespacePartitioningStrategy { }
    }
    public class AzureServiceBusNamespaceRoutingSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public void AddNamespace(string name, string connectionString) { }
    }
    public class AzureServiceBusQueueSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusQueueSettings AutoDeleteOnIdle(System.TimeSpan autoDeleteOnIdle) { }
        public NServiceBus.AzureServiceBusQueueSettings DefaultMessageTimeToLive(System.TimeSpan defaultMessageTimeToLive) { }
        public NServiceBus.AzureServiceBusQueueSettings DescriptionCustomizer(System.Action<Microsoft.ServiceBus.Messaging.QueueDescription> customizer) { }
        [System.ObsoleteAttribute("Replaced with new API. Use `DescriptionCustomizer(Action<QueueDescription>)` inst" +
            "ead. The member currently throws a NotImplementedException. Will be removed in v" +
            "ersion 9.0.0.", true)]
        public NServiceBus.AzureServiceBusQueueSettings DescriptionFactory(System.Func<string, string, NServiceBus.Settings.ReadOnlySettings, Microsoft.ServiceBus.Messaging.QueueDescription> factory) { }
        public NServiceBus.AzureServiceBusQueueSettings DuplicateDetectionHistoryTimeWindow(System.TimeSpan duplicateDetectionHistoryTimeWindow) { }
        public NServiceBus.AzureServiceBusQueueSettings EnableBatchedOperations(bool enableBatchedOperations) { }
        public NServiceBus.AzureServiceBusQueueSettings EnableDeadLetteringOnMessageExpiration(bool enableDeadLetteringOnMessageExpiration) { }
        public NServiceBus.AzureServiceBusQueueSettings EnableExpress(bool enableExpress) { }
        public NServiceBus.AzureServiceBusQueueSettings EnableExpress(System.Func<string, bool> condition, bool enableExpress) { }
        public NServiceBus.AzureServiceBusQueueSettings EnablePartitioning(bool enablePartitioning) { }
        public NServiceBus.AzureServiceBusQueueSettings ForwardDeadLetteredMessagesTo(string forwardDeadLetteredMessagesTo) { }
        public NServiceBus.AzureServiceBusQueueSettings ForwardDeadLetteredMessagesTo(System.Func<string, bool> condition, string forwardDeadLetteredMessagesTo) { }
        public NServiceBus.AzureServiceBusQueueSettings LockDuration(System.TimeSpan duration) { }
        public NServiceBus.AzureServiceBusQueueSettings MaxDeliveryCount(int maxDeliveryCount) { }
        public NServiceBus.AzureServiceBusQueueSettings MaxSizeInMegabytes(NServiceBus.SizeInMegabytes maxSizeInMegabytes) { }
        public NServiceBus.AzureServiceBusQueueSettings RequiresDuplicateDetection(bool requiresDuplicateDetection) { }
        public NServiceBus.AzureServiceBusQueueSettings SupportOrdering(bool supportOrdering) { }
    }
    public class AzureServiceBusSanitizationExtensionPoint<T> : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
        where T : NServiceBus.Transport.AzureServiceBus.ISanitizationStrategy
    {
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> Hash(System.Func<string, string> hash) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> QueuePathSanitization(System.Func<string, string> queuePathSanitizer) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> QueuePathValidation(System.Func<string, NServiceBus.Transport.AzureServiceBus.ValidationResult> queuePathValidator) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> RuleNameSanitization(System.Func<string, string> ruleNameSanitizer) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> RuleNameValidation(System.Func<string, NServiceBus.Transport.AzureServiceBus.ValidationResult> ruleNameValidator) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> SubscriptionNameSanitization(System.Func<string, string> subscriptionNameSanitizer) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> SubscriptionNameValidation(System.Func<string, NServiceBus.Transport.AzureServiceBus.ValidationResult> subscriptionNameValidator) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> TopicPathSanitization(System.Func<string, string> topicPathSanitizer) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> TopicPathValidation(System.Func<string, NServiceBus.Transport.AzureServiceBus.ValidationResult> topicPathValidator) { }
    }
    public class AzureServiceBusSanitizationSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusSanitizationSettings UseQueuePathMaximumLength(int queuePathMaximumLength) { }
        public NServiceBus.AzureServiceBusSanitizationSettings UseRulePathMaximumLength(int rulePathMaximumLength) { }
        public NServiceBus.AzureServiceBusSanitizationExtensionPoint<T> UseStrategy<T>()
            where T : NServiceBus.Transport.AzureServiceBus.ISanitizationStrategy { }
        public NServiceBus.AzureServiceBusSanitizationSettings UseSubscriptionPathMaximumLength(int subscriptionPathMaximumLength) { }
        public NServiceBus.AzureServiceBusSanitizationSettings UseTopicPathMaximumLength(int topicPathMaximumLength) { }
    }
    public class AzureServiceBusSubscriptionSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusSubscriptionSettings AutoDeleteOnIdle(System.TimeSpan autoDeleteOnIdle) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings DefaultMessageTimeToLive(System.TimeSpan expiryTimespan) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings DescriptionFactory(System.Action<Microsoft.ServiceBus.Messaging.SubscriptionDescription> factory) { }
        [System.ObsoleteAttribute("Replaced with new API. Use `DescriptionCustomizer(Action<SubscriptionDescription>" +
            ")` instead. The member currently throws a NotImplementedException. Will be remov" +
            "ed in version 9.0.0.", true)]
        public NServiceBus.AzureServiceBusSubscriptionSettings DescriptionFactory(System.Func<string, string, NServiceBus.Settings.ReadOnlySettings, Microsoft.ServiceBus.Messaging.SubscriptionDescription> factory) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings EnableBatchedOperations(bool enableBatchedOperations) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings EnableDeadLetteringOnFilterEvaluationExceptions(bool enableDeadLetteringOnFilterEvaluationExceptions) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings EnableDeadLetteringOnMessageExpiration(bool enableDeadLetteringOnMessageExpiration) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings ForwardDeadLetteredMessagesTo(string forwardDeadLetteredMessagesTo) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings ForwardDeadLetteredMessagesTo(System.Func<string, bool> condition, string forwardDeadLetteredMessagesTo) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings LockDuration(System.TimeSpan lockDuration) { }
        public NServiceBus.AzureServiceBusSubscriptionSettings MaxDeliveryCount(int maxDeliveryCount) { }
    }
    public class AzureServiceBusTopicSettings : NServiceBus.Configuration.AdvanceExtensibility.ExposeSettings
    {
        public NServiceBus.AzureServiceBusTopicSettings AutoDeleteOnIdle(System.TimeSpan autoDeleteOnIdle) { }
        public NServiceBus.AzureServiceBusTopicSettings DefaultMessageTimeToLive(System.TimeSpan timeToLive) { }
        public NServiceBus.AzureServiceBusTopicSettings DescriptionFactory(System.Action<Microsoft.ServiceBus.Messaging.TopicDescription> factory) { }
        [System.ObsoleteAttribute("Replaced with new API. Use `DescriptionCustomizer(Action<TopicDescription>)` inst" +
            "ead. The member currently throws a NotImplementedException. Will be removed in v" +
            "ersion 9.0.0.", true)]
        public NServiceBus.AzureServiceBusTopicSettings DescriptionFactory(System.Func<string, string, NServiceBus.Settings.ReadOnlySettings, Microsoft.ServiceBus.Messaging.TopicDescription> factory) { }
        public NServiceBus.AzureServiceBusTopicSettings DuplicateDetectionHistoryTimeWindow(System.TimeSpan duplicateDetectionHistoryTimeWindow) { }
        public NServiceBus.AzureServiceBusTopicSettings EnableBatchedOperations(bool enableBatchedOperations) { }
        public NServiceBus.AzureServiceBusTopicSettings EnableExpress(bool enableExpress) { }
        public NServiceBus.AzureServiceBusTopicSettings EnableExpress(System.Func<string, bool> condition, bool enableExpress) { }
        public NServiceBus.AzureServiceBusTopicSettings EnableFilteringMessagesBeforePublishing(bool enableFilteringMessagesBeforePublishing) { }
        public NServiceBus.AzureServiceBusTopicSettings EnablePartitioning(bool enablePartitioning) { }
        public NServiceBus.AzureServiceBusTopicSettings MaxSizeInMegabytes(NServiceBus.SizeInMegabytes maxSizeInMegabytes) { }
        public NServiceBus.AzureServiceBusTopicSettings RequiresDuplicateDetection(bool requiresDuplicateDetection) { }
        public NServiceBus.AzureServiceBusTopicSettings SupportOrdering(bool supported) { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class AzureServiceBusTopologySettings<T> : NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport>
        where T : NServiceBus.Transport.AzureServiceBus.ITopology
    {
        public AzureServiceBusTopologySettings(NServiceBus.Settings.SettingsHolder settings) { }
    }
    public class AzureServiceBusTransport : NServiceBus.Transport.TransportDefinition
    {
        public AzureServiceBusTransport() { }
        public override string ExampleConnectionStringForErrorMessage { get; }
        public override bool RequiresConnectionString { get; }
        public override NServiceBus.Transport.TransportInfrastructure Initialize(NServiceBus.Settings.SettingsHolder settings, string connectionString) { }
    }
    public class static AzureServiceBusTransportExtensions
    {
        public static void BrokeredMessageBodyType(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, NServiceBus.Transport.AzureServiceBus.SupportedBrokeredMessageBodyTypes type) { }
        public static NServiceBus.AzureServiceBusCompositionSettings Composition(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static void ConnectivityMode(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, Microsoft.ServiceBus.ConnectivityMode connectivityMode) { }
        public static void DefaultNamespaceAlias(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, string alias) { }
        public static NServiceBus.AzureServiceBusIndividualizationSettings Individualization(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusMessageReceiverSettings MessageReceivers(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusMessageSenderSettings MessageSenders(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusMessagingFactoriesSettings MessagingFactories(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusNamespaceManagersSettings NamespaceManagers(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusNamespacePartitioningSettings NamespacePartitioning(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusNamespaceRoutingSettings NamespaceRouting(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static void NumberOfClientsPerEntity(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, int number) { }
        public static NServiceBus.AzureServiceBusQueueSettings Queues(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusSanitizationSettings Sanitization(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static void SendViaReceiveQueue(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, bool sendViaReceiveQueue) { }
        public static NServiceBus.AzureServiceBusSubscriptionSettings Subscriptions(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusTopicSettings Topics(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static void TransportType(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, Microsoft.ServiceBus.Messaging.TransportType transportType) { }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static void UseBrokeredMessageToIncomingMessageConverter<T>(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions)
            where T : NServiceBus.Transport.AzureServiceBus.IConvertBrokeredMessagesToIncomingMessages { }
        public static NServiceBus.AzureServiceBusEndpointOrientedTopologySettings UseEndpointOrientedTopology(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static NServiceBus.AzureServiceBusForwardingTopologySettings UseForwardingTopology(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        public static void UseNamespaceAliasesInsteadOfConnectionStrings(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions) { }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public static void UseOutgoingMessageToBrokeredMessageConverter<T>(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions)
            where T : NServiceBus.Transport.AzureServiceBus.IConvertOutgoingMessagesToBrokeredMessages { }
        [System.ObsoleteAttribute("Internal contract. Use `transport.UseForwardingTopology() or transport.UseEndpoin" +
            "tOrientedTopology()` instead. The member currently throws a NotImplementedExcept" +
            "ion. Will be removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusTopologySettings<T> UseTopology<T>(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions)
            where T : NServiceBus.Transport.AzureServiceBus.ITopology, new () { }
        [System.ObsoleteAttribute("Internal contract. Use `transport.UseForwardingTopology() or transport.UseEndpoin" +
            "tOrientedTopology()` instead. The member currently throws a NotImplementedExcept" +
            "ion. Will be removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusTopologySettings<T> UseTopology<T>(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, System.Func<T> factory)
            where T : NServiceBus.Transport.AzureServiceBus.ITopology { }
        [System.ObsoleteAttribute("Internal contract. Use `transport.UseForwardingTopology() or transport.UseEndpoin" +
            "tOrientedTopology()` instead. The member currently throws a NotImplementedExcept" +
            "ion. Will be removed in version 9.0.0.", true)]
        public static NServiceBus.AzureServiceBusTopologySettings<T> UseTopology<T>(this NServiceBus.TransportExtensions<NServiceBus.AzureServiceBusTransport> transportExtensions, T topology)
            where T : NServiceBus.Transport.AzureServiceBus.ITopology { }
    }
    public class CoreIndividualization : NServiceBus.Transport.AzureServiceBus.IIndividualizationStrategy
    {
        public string Individualize(string endpointName) { }
    }
    public class DiscriminatorBasedIndividualization : NServiceBus.Transport.AzureServiceBus.IIndividualizationStrategy
    {
        public string Individualize(string endpointName) { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class EndpointOrientedTopology : NServiceBus.Transport.AzureServiceBus.ITopology
    {
        public EndpointOrientedTopology() { }
    }
    public enum EntityType
    {
        Queue = 0,
        Topic = 1,
        Subscription = 2,
        Rule = 3,
    }
    public class FailOverNamespacePartitioning : NServiceBus.Transport.AzureServiceBus.INamespacePartitioningStrategy
    {
        public NServiceBus.Transport.AzureServiceBus.FailOverMode Mode { get; set; }
        [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(NServiceBus.FailOverNamespacePartitioning.<GetNamespaces>d__6))]
        public System.Collections.Generic.IEnumerable<NServiceBus.Transport.AzureServiceBus.RuntimeNamespaceInfo> GetNamespaces(NServiceBus.Transport.AzureServiceBus.PartitioningIntent partitioningIntent) { }
    }
    public class FlatComposition : NServiceBus.Transport.AzureServiceBus.ICompositionStrategy
    {
        public FlatComposition() { }
        public string GetEntityPath(string entityname, NServiceBus.EntityType entityType) { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class ForwardingTopology : NServiceBus.Transport.AzureServiceBus.ITopology
    {
        public ForwardingTopology() { }
    }
    public class HierarchyComposition : NServiceBus.Transport.AzureServiceBus.ICompositionStrategy
    {
        public string GetEntityPath(string entityname, NServiceBus.EntityType entityType) { }
    }
    public class RoundRobinNamespacePartitioning : NServiceBus.Transport.AzureServiceBus.INamespacePartitioningStrategy
    {
        [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(NServiceBus.RoundRobinNamespacePartitioning.<GetNamespaces>d__2))]
        public System.Collections.Generic.IEnumerable<NServiceBus.Transport.AzureServiceBus.RuntimeNamespaceInfo> GetNamespaces(NServiceBus.Transport.AzureServiceBus.PartitioningIntent partitioningIntent) { }
    }
    public class SingleNamespacePartitioning : NServiceBus.Transport.AzureServiceBus.INamespacePartitioningStrategy
    {
        [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(NServiceBus.SingleNamespacePartitioning.<GetNamespaces>d__2))]
        public System.Collections.Generic.IEnumerable<NServiceBus.Transport.AzureServiceBus.RuntimeNamespaceInfo> GetNamespaces(NServiceBus.Transport.AzureServiceBus.PartitioningIntent partitioningIntent) { }
    }
    public class SizeInMegabytes
    {
        public static NServiceBus.SizeInMegabytes Size1024;
        public static NServiceBus.SizeInMegabytes Size2048;
        public static NServiceBus.SizeInMegabytes Size3072;
        public static NServiceBus.SizeInMegabytes Size4096;
        public static NServiceBus.SizeInMegabytes Size5120;
        public static NServiceBus.SizeInMegabytes Create(long sizeInMegabytes) { }
    }
    public class ThrowOnFailedValidation : NServiceBus.Transport.AzureServiceBus.ISanitizationStrategy
    {
        public string Sanitize(string entityPathOrName, NServiceBus.EntityType entityType) { }
    }
    public class ValidateAndHashIfNeeded : NServiceBus.Transport.AzureServiceBus.ISanitizationStrategy
    {
        public string Sanitize(string entityPathOrName, NServiceBus.EntityType entityType) { }
    }
}
namespace NServiceBus.Transport.AzureServiceBus
{
    
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class Batch
    {
        public Batch() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class BatchedOperation
    {
        public BatchedOperation() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class BrokeredMessageReceiveContext : NServiceBus.Transport.AzureServiceBus.ReceiveContext
    {
        public BrokeredMessageReceiveContext() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class ConnectionString
    {
        public ConnectionString() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class EntityInfo
    {
        public EntityInfo() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class EntityRelationShipInfo
    {
        public EntityRelationShipInfo() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public enum EntityRelationShipType { }
    public enum FailOverMode
    {
        Primary = 0,
        Secondary = 1,
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IBatcher { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IBrokerSideSubscriptionFilter { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IClientEntity { }
    [System.ObsoleteAttribute("Internal unutilized contract that shouldn\'t be exposed. Will be removed in versio" +
        "n 9.0.0.", true)]
    public interface IClientSideSubscriptionFilter { }
    public interface ICompositionStrategy
    {
        string GetEntityPath(string entityname, NServiceBus.EntityType entityType);
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IConvertBrokeredMessagesToIncomingMessages { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IConvertOutgoingMessagesToBrokeredMessages { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateAzureServiceBusQueues { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateAzureServiceBusSubscriptions { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateAzureServiceBusTopics { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateMessageReceivers { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateMessageSenders { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateMessagingFactories { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateNamespaceManagers { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ICreateTopology { }
    public interface IHandleOversizedBrokeredMessages
    {
        System.Threading.Tasks.Task Handle(Microsoft.ServiceBus.Messaging.BrokeredMessage brokeredMessage);
    }
    public interface IIndividualizationStrategy
    {
        string Individualize(string endpointName);
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IManageMessageReceiverLifeCycle { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IManageMessageSenderLifeCycle { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IManageMessagingFactoryLifeCycle { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IManageNamespaceManagerLifeCycle { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IMessageReceiver : NServiceBus.Transport.AzureServiceBus.IClientEntity { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IMessageSender : NServiceBus.Transport.AzureServiceBus.IClientEntity { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IMessagingFactory : NServiceBus.Transport.AzureServiceBus.IClientEntity { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface INamespaceManager { }
    public interface INamespacePartitioningStrategy
    {
        System.Collections.Generic.IEnumerable<NServiceBus.Transport.AzureServiceBus.RuntimeNamespaceInfo> GetNamespaces(NServiceBus.Transport.AzureServiceBus.PartitioningIntent partitioningIntent);
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class IncomingMessageDetails
    {
        public IncomingMessageDetails() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface INotifyIncomingMessages { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IOperateTopology { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IRegisterTransportParts { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IResolveTransportParts { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface IRouteOutgoingBatches { }
    public interface ISanitizationStrategy
    {
        string Sanitize(string entityPathOrName, NServiceBus.EntityType entityType);
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ITopology { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ITopologySectionManager { }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public interface ITransportPartsContainer : NServiceBus.Transport.AzureServiceBus.IRegisterTransportParts, NServiceBus.Transport.AzureServiceBus.IResolveTransportParts { }
    public class MessageTooLargeException : System.Exception
    {
        public MessageTooLargeException() { }
        public MessageTooLargeException(string message) { }
        public MessageTooLargeException(string message, System.Exception inner) { }
        protected MessageTooLargeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public class NamespaceConfigurations : System.Collections.Generic.IEnumerable<NServiceBus.Transport.AzureServiceBus.NamespaceInfo>, System.Collections.IEnumerable
    {
        public NamespaceConfigurations() { }
        public int Count { get; }
        public void Add(string alias, string connectionString, NServiceBus.Transport.AzureServiceBus.NamespacePurpose purpose) { }
        public string GetConnectionString(string name) { }
        public System.Collections.Generic.IEnumerator<NServiceBus.Transport.AzureServiceBus.NamespaceInfo> GetEnumerator() { }
    }
    public class NamespaceInfo : System.IEquatable<NServiceBus.Transport.AzureServiceBus.NamespaceInfo>
    {
        public NamespaceInfo(string alias, string connectionString, NServiceBus.Transport.AzureServiceBus.NamespacePurpose purpose = 1) { }
        public string Alias { get; }
        public string Connection { get; }
        [System.ObsoleteAttribute("Internal contract. The member currently throws a NotImplementedException. Will be" +
            " removed in version 9.0.0.", true)]
        public NServiceBus.Transport.AzureServiceBus.ConnectionString ConnectionString { get; }
        public NServiceBus.Transport.AzureServiceBus.NamespacePurpose Purpose { get; }
        public bool Equals(NServiceBus.Transport.AzureServiceBus.NamespaceInfo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class NamespaceManagerAdapter : NServiceBus.Transport.AzureServiceBus.INamespaceManager
    {
        public NamespaceManagerAdapter() { }
    }
    public enum NamespaceMode
    {
        Active = 0,
        Passive = 1,
    }
    public enum NamespacePurpose
    {
        Routing = 0,
        Partitioning = 1,
    }
    public enum PartitioningIntent
    {
        Receiving = 0,
        Sending = 1,
        Creating = 2,
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public abstract class ReceiveContext
    {
        protected ReceiveContext() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class RoutingOptions
    {
        public RoutingOptions() { }
    }
    public class RuntimeNamespaceInfo : System.IEquatable<NServiceBus.Transport.AzureServiceBus.RuntimeNamespaceInfo>
    {
        public RuntimeNamespaceInfo(string alias, string connectionString, NServiceBus.Transport.AzureServiceBus.NamespacePurpose purpose = 1, NServiceBus.Transport.AzureServiceBus.NamespaceMode mode = 0) { }
        public string Alias { get; }
        public string ConnectionString { get; }
        public NServiceBus.Transport.AzureServiceBus.NamespaceMode Mode { get; }
        public bool Equals(NServiceBus.Transport.AzureServiceBus.RuntimeNamespaceInfo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class SubscriptionInfo : NServiceBus.Transport.AzureServiceBus.EntityInfo
    {
        public SubscriptionInfo() { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class SubscriptionMetadata
    {
        public SubscriptionMetadata() { }
    }
    public enum SupportedBrokeredMessageBodyTypes
    {
        ByteArray = 0,
        Stream = 1,
    }
    public class ThrowOnOversizedBrokeredMessages : NServiceBus.Transport.AzureServiceBus.IHandleOversizedBrokeredMessages
    {
        public ThrowOnOversizedBrokeredMessages() { }
        public System.Threading.Tasks.Task Handle(Microsoft.ServiceBus.Messaging.BrokeredMessage brokeredMessage) { }
    }
    [System.ObsoleteAttribute("Internal contract. Will be removed in version 9.0.0.", true)]
    public class TopologySection
    {
        public TopologySection() { }
    }
    public class TransactionContainsTooManyMessages : System.Exception
    {
        public TransactionContainsTooManyMessages() { }
        public TransactionContainsTooManyMessages(string message = "Azure Service Bus cannot send more than 100 messages in a signle transaction. Reduce number of messages sent out or reduce transport transaction mode.") { }
        public TransactionContainsTooManyMessages(string message, System.Exception inner) { }
        public TransactionContainsTooManyMessages(System.Exception inner) { }
        protected TransactionContainsTooManyMessages(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public class UnsupportedBrokeredMessageBodyTypeException : System.Exception
    {
        public UnsupportedBrokeredMessageBodyTypeException() { }
        public UnsupportedBrokeredMessageBodyTypeException(string message) { }
        public UnsupportedBrokeredMessageBodyTypeException(string message, System.Exception innerException) { }
        protected UnsupportedBrokeredMessageBodyTypeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public class ValidationResult
    {
        public ValidationResult() { }
        public bool CharactersAreValid { get; }
        public string CharactersError { get; set; }
        public bool IsValid { get; }
        public string LengthError { get; set; }
        public bool LengthIsValid { get; }
        public void AddErrorForInvalidCharacters(string error) { }
        public void AddErrorForInvalidLenth(string error) { }
    }
}