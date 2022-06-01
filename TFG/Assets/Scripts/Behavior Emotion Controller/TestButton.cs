using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestButton : MonoBehaviour
{
    public int arboln;
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
        test.Loadnextscene(arboln);
    }
}
