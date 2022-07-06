using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;
namespace BehaviorEmotion
{
    public class stopcrono : Action
    {
        private cronometro crono;
        public override void OnStart()
        {

            crono = GameObject.Find("cron").GetComponent<cronometro>();
            //index = controller.retemotionindex(em);
        }
        // Start is called before the first frame update
        //void Start()
        //{

        //}

        // Update is called once per frame
        //void Update()
        //{

        //}
        public override TaskStatus OnUpdate()
        {
            crono.stoped();
            return TaskStatus.Success;
        }
    }
}
