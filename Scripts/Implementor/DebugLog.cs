using UnityEngine;

namespace DefaultNamespace.Im
{
    public class DebugLog:MonoBehaviour,ILogImplementor
    {
        public void Log(string message)
        {
            Debug.Log(message);
        }
    }
}