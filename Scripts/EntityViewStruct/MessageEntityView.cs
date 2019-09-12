using Svelto.ECS;
using Svelto.ECS.Experimental;
using Svelto.ECS.Hybrid;

namespace DefaultNamespace
{
    public struct MessageEntityView:IEntityViewStruct
    {
        public ECSString Message;
        public EGID ID { get; set; }
    }
}