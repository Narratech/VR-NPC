using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.IO;
public class cronometro : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private float segundos = 0;
    private int minutos = 0;
    private int horas = 0;
    public bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            segundos += Time.deltaTime;
            if (segundos >= 60)
            {
                segundos = 0;
                minutos++;
            }
            if (minutos >= 60)
            {
                minutos = 0;
                horas++;
            }
            texto.text = "Tiempo transcurrido:" + segundos + "segundos, " + minutos + " minutos , " + horas + " horas ";
        }
    }
    public void stoped()
    {
        stop = true;
        texto.text += "\n Felicicidades has conseguido escapar " ;
        StreamWriter sw = new StreamWriter("tiempo.txt");
        sw.WriteLine("Tiempo transcurrido:" + segundos + "segundos, " + minutos + " minutos , " + horas + " horas ");
        sw.Close();
    }
}
