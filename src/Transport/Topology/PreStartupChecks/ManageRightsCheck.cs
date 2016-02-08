namespace NServiceBus.AzureServiceBus
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using NServiceBus.Settings;
    using NServiceBus.Transports;

    class ManageRightsCheck 
    {
        private readonly IManageNamespaceManagerLifeCycle manageNamespaceManagerLifeCycle;
        private readonly ReadOnlySettings settings;

        public ManageRightsCheck(ITransportPartsContainer container)
        {
            this.manageNamespaceManagerLifeCycle = container.Resolve<IManageNamespaceManagerLifeCycle>();
            this.settings = container.Resolve<ReadOnlySettings>();
        }

        public async Task<StartupCheckResult> Apply()
        {
            if (!settings.Get<bool>(WellKnownConfigurationKeys.Core.CreateTopology))
                return StartupCheckResult.Success;

            var tasks = settings.Get<List<string>>(WellKnownConfigurationKeys.Topology.Addressing.Partitioning.Namespaces)
                .Select(x => manageNamespaceManagerLifeCycle.Get(x))
                .Select(async x => await x.HasManageRights());

            return (await Task.WhenAll(tasks)).Any(x => !x) ?
                StartupCheckResult.Failed($"Manage rights on namespace is required if {WellKnownConfigurationKeys.Core.CreateTopology} is true") : 
                StartupCheckResult.Success;
        }
    }
}