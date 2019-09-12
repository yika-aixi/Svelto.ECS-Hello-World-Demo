using System.Collections;
using DefaultNamespace.Descriptor;
using DefaultNamespace.Im;
using Svelto.ECS;
using Svelto.Tasks;

namespace DefaultNamespace.Engine
{
    public class DebugMessageEngine:IMessageEngine
    {
        private IEntityFunctions entityFunctions;
        private ILogImplementor log;

        public DebugMessageEngine(IEntityFunctions entityFunctions,ILogImplementor logImplementor)
        {
            this.entityFunctions = entityFunctions;
            this.log = logImplementor;
        }

        public IEntitiesDB entitiesDB { get; set; }
        public void Ready()
        {
            ShowMessage().RunOnScheduler(StandardSchedulers.updateScheduler);
        }

        IEnumerator ShowMessage()
        {

            while (true)
            {

                var messagesEntitys =
                    entitiesDB.QueryEntities<MessageEntity>(EntityGroup.Message, out var messageCount);
                
                for (var i = 0; i < messageCount; i++)
                {
                    log.Log(messagesEntitys[i].Message);
                    entityFunctions.RemoveEntity<MessageEntityDescriptor>(messagesEntitys[i].ID);
                }
                
                yield return null;
            }
        }
    }
}