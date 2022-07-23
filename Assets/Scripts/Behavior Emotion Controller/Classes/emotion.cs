using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emotion : MonoBehaviour
{
    public string nombre;
    public double valor;
    public enum status {negative,positive};
    public double multiplicador = 0;
    public double umbral;
    public double getvalor()
    {
        return valor;
    }
    public void increase()
    {
        valor += (multiplicador * 0.1);
        if (valor > umbral)
        {
            valor = umbral;
        }
    }
    public void decrease()
    {
        valor -= (multiplicador * 0.08);
        if (valor < 0)
        {
            valor = 0;
        }
    } 
    public void decreaseval(double dec)
    {
        valor -= dec;
        if (valor < 0)
        {
            valor = 0;
        }
    }
    public double retcuant()
    {
        return multiplicador*0.1;
    }
    public void incmin()
    {
        valor += (multiplicador*0.04);
        if (valor > umbral)
        {
            valor = umbral;
        }
    }
    public void decmin()
    {
        valor -= (0.04);
        if (valor < 0)
        {
            valor = 0;
        }
    }
}
