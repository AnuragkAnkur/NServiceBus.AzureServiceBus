﻿namespace NServiceBus.AcceptanceTests.Persistence
{
    using System.Collections.Generic;
    using NServiceBus.AcceptanceTesting;
    using NServiceBus.AcceptanceTests.EndpointTemplates;
    using NServiceBus.Persistence;
    using NUnit.Framework;
    using System.Threading.Tasks;
    using Extensibility;
    using Unicast.Subscriptions;
    using Unicast.Subscriptions.MessageDrivenSubscriptions;

    public class When_a_persistence_does_not_provide_ISynchronizationContext
    {
        [Test]
        public async Task ReceiveFeature_should_work_without_ISynchronizedStorage()
        {
            await Scenario.Define<Context>()
                .WithEndpoint<NoSyncEndpoint>(e => e.When(b => b.SendLocal(new MyMessage())))
                .Done(c => c.MessageRecieved)
                .Run();
        }

        class InMemoryNoSyncContextPersistence : PersistenceDefinition
        {
            public InMemoryNoSyncContextPersistence()
            {
                Supports<StorageType.Timeouts>(s => { });
                Supports<StorageType.Sagas>(s => { });
                Supports<StorageType.Subscriptions>(s => { });
            }
        }

        class NoOpISubscriptionStorage : ISubscriptionStorage
        {
            public Task<IEnumerable<Subscriber>> GetSubscriberAddressesForMessage(IEnumerable<MessageType> messageTypes, ContextBag context)
            {
                return Task.FromResult<IEnumerable<Subscriber>>(null);
            }

            public Task Subscribe(Subscriber subscriber, MessageType messageType, ContextBag context)
            {
                return Task.FromResult(0);
            }

            public Task Unsubscribe(Subscriber subscriber, MessageType messageType, ContextBag context)
            {
                return Task.FromResult(0);
            }
        }

        class NoSyncEndpoint : EndpointConfigurationBuilder
        {
            public NoSyncEndpoint()
            {
                EndpointSetup<ServerWithNoDefaultPersistenceDefinitions>(c =>
                {
                    c.RegisterComponents(container => container.ConfigureComponent<NoOpISubscriptionStorage>(DependencyLifecycle.SingleInstance));
                    c.UsePersistence<InMemoryNoSyncContextPersistence>();
                });
            }
        }

        public class MyMessageHandler : IHandleMessages<MyMessage>
        {
            public Context Context { get; set; }

            public Task Handle(MyMessage message, IMessageHandlerContext context)
            {
                Context.MessageRecieved = true;

                return Task.FromResult(0);
            }
        }

        public class Context : ScenarioContext
        {
            public bool NotSet { get; set; }
            public bool MessageRecieved { get; set; }
        }

        public class MyMessage : ICommand
        {
        }
    }
}
