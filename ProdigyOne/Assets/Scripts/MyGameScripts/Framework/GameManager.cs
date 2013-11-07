using Assets.Scripts.MyGenericScripts.Framework.Messaging;
using UnityEngine;

namespace Assets.Scripts.MyGameScripts.Framework
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        private GameManager()
        {
        }

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameManager();
                }

                return _instance;
            }
        }

        protected void Awake()
        {
        }

        protected void Start()
        {
        }

        protected void Update()
        {
            MessagePump.Instance.Update(Time.fixedDeltaTime);
        }
    }
}
