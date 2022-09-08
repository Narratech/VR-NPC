using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
namespace BehaviorEmotion
{
    [TaskCategory("BehaviorEmotion/Selectors")]
    public class SoundEmotional : Action
    {
        private GameObject target;
        public string nombre;
        public float time;
        private AudioSource audioSource;
        public override void OnStart()
        {
            target = GameObject.Find(nombre);
            audioSource = target.GetComponent<AudioSource>();

        }
        public override TaskStatus OnUpdate()
        {
            if (audioSource == null)
            {
                Debug.LogWarning("AudioSource is null");
                return TaskStatus.Failure;
            }

            audioSource.PlayScheduled(time);

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            target = null;
            time = 0;
        }
    }
}
