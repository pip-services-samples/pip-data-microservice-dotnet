using Beacons.Build;
using PipServices3.Container;
using PipServices3.Rpc.Build;
using PipServices3.Swagger.Build;

namespace Beacons.Containers
{
    public class BeaconsProcess : ProcessContainer
    {
        public BeaconsProcess()
            : base("beacons", "Beacons microservice")
        {
            AddFactory(new DefaultRpcFactory());
            AddFactory(new DefaultSwaggerFactory());
            AddFactory(new BeaconsServiceFactory());
        }
    }
}
