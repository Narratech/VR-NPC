using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emotionaltriggerpotions : MonoBehaviour
{
    public string positive;
    public string negative;
    public EmotionalController cont;
    private int pospositive;
    private int posnegative;
    private Potion sp;
    private bool onfloor = false;
    // Start is called before the first frame update
    void Start()
    {
        this.sp = this.GetComponent<Potion>();
        posnegative = cont.retemotionindex(negative);
        pospositive = cont.retemotionindex(positive);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.sp.fillAmount < 0.4 && !onfloor)
        {
            adjust();
        }
        if (this.transform.position.y > 20.2)
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
