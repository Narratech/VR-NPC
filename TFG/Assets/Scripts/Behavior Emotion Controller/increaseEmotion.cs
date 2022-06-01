using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;
namespace BehaviorEmotion {
    [TaskDescription("aumentamos la emocion seleccionada ")]
    public class increaseEmotion : Action
    {
        public string em;
        private EmotionalController controller;
        int index;
        public override void OnStart()
        {
            
            controller = GameObject.Find("EmotionalSistem").GetComponent<EmotionalController>();
            index = controller.retemotionindex(em);
        }

        public override TaskStatus OnUpdate() {
            if (index > 6)
            {
                return TaskStatus.Failure;
            }
            else
            {
                this.controller.actone(index);
                return TaskStatus.Success;
            }

        }
    }





}


