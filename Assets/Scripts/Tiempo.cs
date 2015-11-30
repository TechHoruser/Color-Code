using System;
using UnityEngine.UI;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public Boolean pulsado;
    public GameObject res;
    public GameObject mens;
    GameObject ok;
    public Boolean started;
    float flotante;
    public void Start()
    {
        started = false;
        res=GameObject.Find("Restart");
        mens=GameObject.Find("Mensaje");
        ok = GameObject.Find("OK");
        res.SetActive(false);
        mens.SetActive(false);
        ok.SetActive(false);
        pulsado = false;
    }

    public void Update()
    {

        
        if (pulsado)
        {
            InputField infi = GameObject.Find("Cronometro").GetComponent<InputField>();
            flotante = (flotante - Time.deltaTime);
            int t = (int)flotante;
            if (flotante > 0)
            {
                //infi.text = flotante.ToString();
            }
            else
            {
                infi.text = "0";
                //mensaje
                mens.SetActive(true);
                mens.GetComponent<Text>().text = "Se te ha agotado el tiempo";
                res.SetActive(true);

            }
        }

    }

    public void comenzar()
    {
        ok.SetActive(true);
        started = true;
        pulsado = true;
        GameObject.Find("Cronometro").GetComponent<InputField>().interactable=false;
        flotante = float.Parse(GameObject.Find("Cronometro").GetComponent<InputField>().text);

    }

    public void restart()
    { Application.LoadLevel(Application.loadedLevel); }
}