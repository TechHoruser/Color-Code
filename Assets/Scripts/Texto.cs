using UnityEngine;
using System.Collections;

public class Texto : MonoBehaviour {
	// Use this for initialization
	void Start () {
        

        
    }

    // Update is called once per frame
    void Update() {

        if (GameObject.Find("Start").GetComponent<Tiempo>().started) { 
            int p = this.transform.parent.GetComponent<Vuforia.MarkerBehaviour>().Marker.MarkerID;
            int posicion = GameObject.Find("Compartir").GetComponent<Asignar>().posiciones[p];
            GetComponent<TextMesh>().text = GameObject.Find("Compartir").GetComponent<Asignar>().numeros[posicion].ToString();
            GetComponent<TextMesh>().color = GameObject.Find("Compartir").GetComponent<Asignar>().colores[posicion];
        }
        else
        {
            GetComponent<TextMesh>().text = "#";
            GetComponent<TextMesh>().color = Color.black;
        }
        this.transform.Rotate(new Vector3(0,3,0));
    }
}
