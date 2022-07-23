using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BehaviorDesigner.Runtime.Tasks
{
    public class Emotionalvalueselector : Composite
    {

        private GameObject selector;
        private EmotionalController control;
        private int currentChildIndex = 0;
        public string emotion;
        public double value1;
        public double value2;
        private int valueemotionalindex;
        private double valueemotional;
        // The task status of the last child ran.
        private TaskStatus executionStatus = TaskStatus.Inactive;
        public override void OnStart()
        {
            selector = GameObject.Find("EmotionalSistem");
            control = selector.GetComponent<EmotionalController>();
            valueemotionalindex = control.retemotionindex(emotion);
            valueemotional = control.conjunto_emocional[valueemotionalindex].valor;
        }

        public override int CurrentChildIndex()
        {
            return Highestmotion();
        }

        public override bool CanExecute()
        {

            // We can continue to execuate as long as we have children that haven't been executed and no child has returned failure.
            //return currentChildIndex < children.Count && executionStatus != TaskStatus.Failure;
            return currentChildIndex == Highestmotion() && executionStatus != TaskStatus.Failure;
        }

        public override void OnChildExecuted(TaskStatus childStatus)
        {
            // Increase the child index and update the execution status after a child has finished running.
            currentChildIndex++;
            executionStatus = childStatus;
        }

        public override void OnConditionalAbort(int childIndex)
        {
            // Set the current child index to the index that caused the abort
            currentChildIndex = Highestmotion();
            executionStatus = TaskStatus.Inactive;
        }

        public override void OnEnd()
        {
            // All of the children have run. Reset the variables back to their starting values.
            executionStatus = TaskStatus.Inactive;
            currentChildIndex = Highestmotion();
        }
        public int Highestmotion()
        {
            valueemotionalindex = control.retemotionindex(emotion);
            valueemotional = control.conjunto_emocional[valueemotionalindex].valor;
            if (valueemotional>0 && valueemotional < value1)
           {
                return 0;
           }
            if (valueemotional > value1 && valueemotional < value2)
            {
                return 1;
            }
            if (valueemotional > value2)
            {
                return 2;
            }
            else return 0;
        }
    }

}
