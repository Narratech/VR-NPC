using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RobotTest : MonoBehaviour
{
    public static int arbol;
    public static double angermultiplier = 1;
    public static double surprisemultiplier = 1;
    public static double sadmultiplier = 1;
    public static double ascomultiplier = 1;
    public static double happymultiplier = 1;
    public static double fearmultiplier = 1;
    public static double disgustmultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void load(double an, double hap, double sad,int value)
    {
        arbol = value;
        angermultiplier = an;
        surprisemultiplier = 1;
        ascomultiplier =1 ;
        sadmultiplier = sad;
        happymultiplier = hap;
        fearmultiplier = 1;
        disgustmultiplier = 1;
        SceneManager.LoadScene("EscapeRoomPrueba");
    }
}
