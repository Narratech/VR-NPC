using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
namespace BehaviorEmotion
{
    [TaskCategory("BehaviorEmotion/Selectors")]
    public class multiplierselector : Composite
    {

        private GameObject selector;
        private EmotionalController control;
        private int currentChildIndex = 0;
        // The task status of the last child ran.
        private TaskStatus executionStatus = TaskStatus.Inactive;
        public override void OnStart()
        {
            selector = GameObject.Find("EmotionalSistem");
            control = selector.GetComponent<EmotionalController>();
            currentChildIndex = Highestmotion();
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
            int index = 0;
            double mayor = 0;
            for (int i = 0; i < this.control.conjunto_emocional.Length; i++)
            {
                if (this.control.conjunto_emocional[i].multiplicador > mayor)
                {
                    index = i;
                    mayor = this.control.conjunto_emocional[i].multiplicador;
                }
            }
            return index;
        }
    }

}