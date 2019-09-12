using Svelto.ECS;
using Svelto.ECS.Experimental;

namespace DefaultNamespace
{
    public struct MessageEntity:IEntityStruct,INeedEGID
    {
        public ECSString Message;

        public EGID ID { get; set; }
    }
}