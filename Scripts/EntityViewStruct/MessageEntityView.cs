using Svelto.ECS;
using Svelto.ECS.Hybrid;

namespace DefaultNamespace
{
    public class MessageEntityView:IEntityViewStruct
    {
        public EGID ID { get; set; }
    }
}