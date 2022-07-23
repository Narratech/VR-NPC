using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BehaviorDesigner.Runtime.Tasks { 

    public class ishigh : Conditional
    {

        private EmotionalController control;
        public string emotion;
        private int index;
        private GameObject selector;
        public double valorcond;
        public override void OnAwake()
        {
            selector = GameObject.Find("EmotionalSistem");
            control = selector.GetComponent<EmotionalController>();
            index = control.retemotionindex(emotion);
        }
        // Start is called before the first frame update
        public override TaskStatus OnUpdate()
        {


            if (control.conjunto_emocional[index].valor>= valorcond)
            {
                
                return TaskStatus.Success;
            }
            else return TaskStatus.Failure;
        }
       
    }
}
