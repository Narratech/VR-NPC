using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
namespace BehaviorEmotion {
    [TaskCategory("BehaviorEmotion/Selectors")]
    public class testSelector : Composite
    {

        // Start is called before the first frame update
        //private GameObject selector;
        //private EmotionalController control;
        private int currentChildIndex = 0;
        // The task status of the last child ran.
        private TaskStatus executionStatus = TaskStatus.Inactive;
        public override void OnStart()
        {
           // selector = GameObject.Find("EmotionalSistem");
            //control = selector.GetComponent<EmotionalController>();
            currentChildIndex = RobotTest.arbol;
        }

        public override int CurrentChildIndex()
        {
            return RobotTest.arbol;
        }

        public override bool CanExecute()
        {

            // We can continue to execuate as long as we have children that haven't been executed and no child has returned failure.
            //return currentChildIndex < children.Count && executionStatus != TaskStatus.Failure;
            return currentChildIndex == RobotTest.arbol && executionStatus != TaskStatus.Failure;
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
            currentChildIndex = RobotTest.arbol;
            executionStatus = TaskStatus.Inactive;
        }

        public override void OnEnd()
        {
            // All of the children have run. Reset the variables back to their starting values.
            executionStatus = TaskStatus.Inactive;
            currentChildIndex = RobotTest.arbol;
        }
      
    }

}
