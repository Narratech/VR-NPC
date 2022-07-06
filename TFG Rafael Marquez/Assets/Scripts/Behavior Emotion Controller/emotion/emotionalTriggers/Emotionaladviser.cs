using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emotionaladviser : MonoBehaviour
{
    public string positive;
    public string negative;
    public EmotionalController cont;
    private int pospositive;
    private int posnegative;
    private Transform transform;
    public bool onfloor =false;
    // Start is called before the first frame update
    void Start()
    {
        this.transform=this.GetComponent<Transform>();
        posnegative = cont.retemotionindex(negative);
        pospositive = cont.retemotionindex(positive);

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y<0.1 && !onfloor)
        {
            adjust();
        }
        if(this.transform.position.y > 0.1)
        {
            onfloor = false;
        }
    }
    public void adjust()
    {
        cont.act(pospositive, posnegative);
        onfloor = true;
    }
}
