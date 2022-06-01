using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class fearbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public double asc;
    public double hap;
    public double sad;
    public double sur;
    public double ang;
    public double disg;
    public double fear;
    private testController test;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        test = GameObject.Find("testController").GetComponent<testController>();
        button = GetComponent<Button>();
        button.onClick.AddListener(setresponse);


    }

    // Update is called once per frame
    void Update()
    {

    }
    void setresponse()
    {
        test.fearless(ang, sur, asc, sad, hap, fear, disg);
    }

}
