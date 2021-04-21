namespace MassTransit.GrpcTransport.Integration
{
    using System;
    using Contexts;
    using Metadata;


    public class GrpcHostNodeContext :
        NodeContext
    {
        public GrpcHostNodeContext(Uri nodeAddress)
        {
            NodeAddress = nodeAddress;
            SessionId = NewId.NextGuid();
        }

        public NodeType NodeType => NodeType.Host;

        public Uri NodeAddress { get; }

        public Guid SessionId { get; }

        public HostInfo Host
        {
            get => HostMetadataCache.Host;
            set => throw new InvalidOperationException("The Host cannot be set on the Host");
        }
    }
}