using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

namespace SocialPresenceVR
{
    [TaskDescription("Devuelve si la llave esta en el suelo ")]
    [TaskCategory("SocialPresenceVR/EscapeRoom")]
    [TaskIcon("Assets/Behavior Designer Movement/Editor/Icons/{SkinColor}Play.png")]
    public class IsKeyOnFloor : Conditional
    {
        private float floor = 0.2f;
        GameObject keyfordesk;
        GameObject emotion_atached;
        emotion sad;
        public override void OnAwake()
        {
            GameObject keyfordesk = GameObject.Find("KeyForDesk");
            emotion_atached = GameObject.Find("sad");
            sad = emotion_atached.GetComponent<emotion>();
        }
        
        public override TaskStatus OnUpdate()
        {
           

            if (IsOnFloor())
            {
                this.sad.increase();
                return TaskStatus.Success;
            }
            else return TaskStatus.Failure;
        }
        private bool IsOnFloor()
        {
            keyfordesk = GameObject.Find("KeyForDesk");
            if (keyfordesk.transform.position.y < floor)
            {
                return true;
            }
            else return false;
        }
    }

}
