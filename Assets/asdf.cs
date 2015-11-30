using UnityEngine;
using System.Collections;

public class asdf : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.GetComponent<Renderer>().materials[0].color = GameObject.Find("Espada").GetComponent<color>().carioca;
    }
}
