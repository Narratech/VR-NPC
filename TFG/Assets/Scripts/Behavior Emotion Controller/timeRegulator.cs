using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeRegulator : MonoBehaviour
{
    private emotion em;
    public int time;
    public bool asc;
    private int counter;
//    public EmotionalController controller;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        em = this.GetComponent<emotion>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == time)
        {
            
            if (asc)
            {
                if (em.valor<0.5)
                {
                    em.incmin();
                }
                else
                {
                    em.decmin();
                }
            }
            else
            {
                em.decmin();
            }
            counter = 0;
        }
        
    }
}
