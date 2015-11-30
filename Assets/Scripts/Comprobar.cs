using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Comprobar : MonoBehaviour {

    // Use this for initialization
    int intentos;
	void Start () {
        intentos = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void comprueba()
    {
        int[] posiciones = GameObject.Find("Compartir").GetComponent<Asignar>().posiciones;
        string cad0 = GameObject.Find("Text0").GetComponent<TextMesh>().text;
        string cad1 = GameObject.Find("Text1").GetComponent<TextMesh>().text;
        string cad2 = GameObject.Find("Text2").GetComponent<TextMesh>().text;
        string btcad0 = GameObject.Find("Texto"+(posiciones[0]+1).ToString()).GetComponent<InputField>().text;
        string btcad1 = GameObject.Find("Texto"+(posiciones[1]+1).ToString()).GetComponent<InputField>().text;
        string btcad2 = GameObject.Find("Texto"+(posiciones[2]+1).ToString()).GetComponent<InputField>().text;
        
        if (cad0 == btcad0 && cad1 == btcad1 && cad2 == btcad2)
        {
            GameObject.Find("Start").GetComponent<Tiempo>().res.SetActive(true);
            GameObject.Find("Start").GetComponent<Tiempo>().mens.SetActive(true);
            GameObject.Find("Start").GetComponent<Tiempo>().mens.GetComponent<Text>().text = "¡ENHORABUENA!";
            GameObject.Find("Start").GetComponent<Tiempo>().pulsado = false;
        }
        else
        {
            intentos++;
            if (intentos < 3)
            {
                GameObject.Find("X" + intentos.ToString()).GetComponent<Text>().color = Color.red;
            }
            else
            {
                GameObject.Find("X" + intentos.ToString()).GetComponent<Text>().color = Color.red;
                GameObject.Find("Start").GetComponent<Tiempo>().mens.SetActive(true);
                GameObject.Find("Start").GetComponent<Tiempo>().mens.GetComponent<Text>().text = "Intentos agotados";
                GameObject.Find("Start").GetComponent<Tiempo>().res.SetActive(true);
                GameObject.Find("Start").GetComponent<Tiempo>().pulsado = false;
            }
        }
    }

}
