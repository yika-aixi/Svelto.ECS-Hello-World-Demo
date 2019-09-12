using System.Collections;
using DefaultNamespace.Descriptor;
using Svelto.ECS;
using Svelto.Tasks;
using UnityEngine;

namespace DefaultNamespace.Engine
{
    public class MouseClickMessageFactorEngine:IMessageFactoryEngine
    {
        private IEntityFactory entityFactory;

        public MouseClickMessageFactorEngine(IEntityFactory entityFactory)
        {
            this.entityFactory = entityFactory;
        }

        public IEntitiesDB entitiesDB { get; set; }
        public void Ready()
        {
            OnMouseClick().RunOnScheduler(StandardSchedulers.updateScheduler);
        }

        private uint count;
        private IEnumerator OnMouseClick()
        {
            while (true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    ++count;
                    var id = new EGID(count, EntityGroup.Message);
                    
                    var entityInit = entityFactory.BuildEntity<MessageEntityDescriptor>(id);
                    
                    entityInit.Init(new MessageEntity()
                    {
                        Message = $"鼠标点击次数:{count}",
                        ID = id
                    });
                }
                
                yield return null;
            }
        }
    }
}