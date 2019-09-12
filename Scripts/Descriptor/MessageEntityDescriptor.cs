using Svelto.ECS;

namespace DefaultNamespace.Descriptor
{
    public class MessageEntityDescriptor:GenericEntityDescriptor<MessageEntity>
    {
        public IEntityBuilder[] entitiesToBuild { get; }
    }
}