using System;
using DefaultNamespace.Engine;
using DefaultNamespace.Im;
using Svelto.ECS;
using Svelto.ECS.Schedulers.Unity;

namespace DefaultNamespace
{
    public class GameMain : UnityEngine.MonoBehaviour
    {
        private EnginesRoot enginesRoot;
        public DebugLog debugMessage;

        private void Awake()
        {
            enginesRoot = new EnginesRoot(new UnityEntitySubmissionScheduler("Hello World! ECS Demo"));

            var entityFunction = enginesRoot.GenerateEntityFunctions();

            var entityFactory = enginesRoot.GenerateEntityFactory();
            
            IMessageEngine messageEngine = new DebugMessageEngine(entityFunction,debugMessage);

            IMessageFactoryEngine messageFactoryEngine = new MouseClickMessageFactorEngine(entityFactory);
            
            enginesRoot.AddEngine(messageEngine);
            enginesRoot.AddEngine(messageFactoryEngine);
        }

        private void OnDestroy()
        {
            enginesRoot.Dispose();
        }
    }
}