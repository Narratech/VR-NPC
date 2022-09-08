using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionalController : MonoBehaviour
{
    public emotion[] conjunto_emocional;
    public int test;
    // Start is called before the first frame update
    void Start()
    {
        if (test == 0)
        {
            conjunto_emocional[0].multiplicador = RobotTest.angermultiplier;
            conjunto_emocional[1].multiplicador = RobotTest.sadmultiplier;
            conjunto_emocional[2].multiplicador = RobotTest.happymultiplier;
            conjunto_emocional[3].multiplicador = RobotTest.disgustmultiplier;
            conjunto_emocional[4].multiplicador = RobotTest.fearmultiplier;
            conjunto_emocional[5].multiplicador = RobotTest.surprisemultiplier;
            conjunto_emocional[6].multiplicador = RobotTest.ascomultiplier;
        }
        if (test == 1)
        {
            conjunto_emocional[0].multiplicador = testController.angermultiplier;
            conjunto_emocional[1].multiplicador = testController.sadmultiplier;
            conjunto_emocional[2].multiplicador = testController.happymultiplier;
            conjunto_emocional[3].multiplicador = testController.disgustmultiplier;
            conjunto_emocional[4].multiplicador = testController.fearmultiplier;
            conjunto_emocional[5].multiplicador = testController.surprisemultiplier;
            conjunto_emocional[6].multiplicador = testController.ascomultiplier;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public int retemotionindex(string em)
    {

        int ret = 0;
        for (int i = 0; i < conjunto_emocional.Length; i++)
        {
            if (em == conjunto_emocional[i].nombre)
            {
                ret = i;
            }
        }
        return ret;
    }
    public void act(int positive, int negative)
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
