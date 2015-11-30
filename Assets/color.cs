using UnityEngine;
using System.Collections;

public class color : MonoBehaviour {
    public Color carioca;
	// Use this for initialization
	void Start() { 
       
        
	}
	
	// Update is called once per frame
	void Update () {
        carioca = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

    }
}
