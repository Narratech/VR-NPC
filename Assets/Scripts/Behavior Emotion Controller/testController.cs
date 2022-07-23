using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testController : MonoBehaviour
{
    public static int arbol;
    public static double angermultiplier=1;
    public static double surprisemultiplier=1;
    public static double sadmultiplier=1;
    public static double ascomultiplier=1;
    public static double happymultiplier=1;
    public static double fearmultiplier=1;
    public static double disgustmultiplier=1;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject t5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            }
    public void Loadnextscene(int opcion)
    {
        arbol = opcion;
        SceneManager.LoadScene("EscapeRoomSP");
    }
    public void anger(double an, double sur, double asc, double sad, double hap, double fear, double disg)
    {
        angermultiplier += an;
        surprisemultiplier += sur;
        ascomultiplier += asc;
        sadmultiplier += sad;
        happymultiplier+=hap;
        fearmultiplier += fear;
        disgustmultiplier += disg;
        t1.gameObject.SetActive(false);
        t2.gameObject.SetActive(true);
    }
    public void sadness(double an, double sur, double asc, double sad, double hap, double fear, double disg)
    {
        angermultiplier += an;
        surprisemultiplier += sur;
        ascomultiplier += asc;
        sadmultiplier += sad;
        happymultiplier += hap;
        fearmultiplier += fear;
        disgustmultiplier += disg;
        t2.gameObject.SetActive(false);
        t3.gameObject.SetActive(true);
    }
    public void Asco(double an, double sur, double asc, double sad, double hap, double fear, double disg)
    {
        angermultiplier += an;
        surprisemultiplier += sur;
        ascomultiplier += asc;
        sadmultiplier += sad;
        happymultiplier += hap;
        fearmultiplier += fear;
        disgustmultiplier += disg;
        t3.gameObject.SetActive(false);
        t4.gameObject.SetActive(true);
    }
    public void happynnes(double an, double sur, double asc, double sad, double happy, double fear, double disg)
    {
        angermultiplier += an;
        surprisemultiplier += sur;
        ascomultiplier += asc;
        sadmultiplier += sad;
        happymultiplier += happy;
        fearmultiplier += fear;
        disgustmultiplier += disg;
        t4.gameObject.SetActive(false);
        t5.gameObject.SetActive(true);
    }
    public void fearless(double an, double sur, double asc, double sad, double hap, double fear, double disg)
    {
        angermultiplier += an;
        surprisemultiplier += sur;
        ascomultiplier += asc;
        sadmultiplier += sad;
        happymultiplier += hap;
        fearmultiplier += fear;
        disgustmultiplier += disg;
        SceneManager.LoadScene("EscapeRoomSP");
    }
    //public void dispect(double disp)
    //{
   //     disgustmultiplier = disp;
 //       t6.gameObject.SetActive(false);
      //  t7.gameObject.SetActive(true);
    //}
    //public void surprise(double surp)
    //{
       // surprisemultiplier = surp;
      //  SceneManager.LoadScene("EscapeRoomSP");
    //}
}
