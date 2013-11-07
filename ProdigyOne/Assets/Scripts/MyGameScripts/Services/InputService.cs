using Assets.Scripts.MyGenericScripts.Framework;
using Assets.Scripts.MyGenericScripts.Framework.Messaging;
using UnityEngine;

namespace Assets.Scripts.MyGameScripts.Services
{
    public class InputService : ProdigyMonoBehaviour
    {
        public string Jump;

        public void Start()
        {
            MessagePump.Instance.AddMessageToSystem("JUMP");
        }

        public void Update()
        {
            if (Input.GetButtonDown(Jump))
            {
                MessagePump.Instance.SendMessage(new ProdigyMessage("JUMP", this));
            }
        }
    }
}
