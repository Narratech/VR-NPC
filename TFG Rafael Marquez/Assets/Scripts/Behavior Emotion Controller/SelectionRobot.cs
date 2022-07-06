using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SelectionRobot : MonoBehaviour
{
    private RobotTest test;
    private Button button;
    public int value;
    public double hap;
    public double ang;
    public double sad;
    // Start is called before the first frame update
    void Start()
    {
        test = GameObject.Find("testController").GetComponent<RobotTest>();
        button = GetComponent<Button>();
        button.onClick.AddListener(setresponse);
    }

    private void setresponse()
    {
        test.load(ang, hap, sad,value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
