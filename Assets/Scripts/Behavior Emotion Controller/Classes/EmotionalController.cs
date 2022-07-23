using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionalController : MonoBehaviour
{   
    public emotion[] conjunto_emocional;

    // Start is called before the first frame update
    void Start()
    {
        //conjunto_emocional[0].multiplicador = testController.angermultiplier;
        //conjunto_emocional[1].multiplicador = testController.sadmultiplier;
        //conjunto_emocional[2].multiplicador = testController.happymultiplier;
        //conjunto_emocional[3].multiplicador = testController.disgustmultiplier;
        //conjunto_emocional[4].multiplicador = testController.fearmultiplier;
        //conjunto_emocional[5].multiplicador = testController.surprisemultiplier;
        //conjunto_emocional[6].multiplicador = testController.ascomultiplier;
        conjunto_emocional[0].multiplicador = RobotTest.angermultiplier;
        conjunto_emocional[1].multiplicador = RobotTest.sadmultiplier;
        conjunto_emocional[2].multiplicador = RobotTest.happymultiplier;
        conjunto_emocional[3].multiplicador = RobotTest.disgustmultiplier;
        conjunto_emocional[4].multiplicador = RobotTest.fearmultiplier;
        conjunto_emocional[5].multiplicador = RobotTest.surprisemultiplier;
        conjunto_emocional[6].multiplicador = RobotTest.ascomultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int retemotionindex(string em)
    {
        if (em == "anger")
        {
            return 0;
        }
        if (em == "sad")
        {
            return 1;
        }
        if (em == "happy")
        {
            return 2;
        }
        if (em == "disgust")
        {
            return 3;
        }
        if (em == "fear")
        {
            return 4;
        }
        if (em == "surprise")
        {
            return 5;
        }
        if (em == "asco")
        {
            return 6;
        }
        else return 7;
    }
    public void act(int positive,int negative)
    {
        if (conjunto_emocional[negative].valor > 0)
        {
            conjunto_emocional[negative].decreaseval(conjunto_emocional[positive].retcuant());
        }
        else
        {
            conjunto_emocional[positive].increase();
        }
    }
    public void subact(int index)
    {
        conjunto_emocional[index].incmin();
    }
    public void actone(int index)
    {
        conjunto_emocional[index].increase();
    }
}
