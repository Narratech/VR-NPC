using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeRegulator : MonoBehaviour
{
    private emotion em;
    public int time;
    public bool asc;
    public bool sad;
    private float counter;
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
        counter += Time.deltaTime; ;
        if (counter >= time)
        {
            if (!sad)
            {
                if (asc)
                {
                    if (em.valor < em.umbral / 2)
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
            //if (asc)
            //{
            //  if (em.valor<em.umbral/2)
            // {
            //     em.incmin();
            // }
            //else
            // {
            //   em.decmin();
            //}
            //}
            //else
            //{
            //  em.decmin();
            //}
            //counter = 0;
            else
            {
                em.increase();
                counter = 0;
            }
        }
        
    }
}
