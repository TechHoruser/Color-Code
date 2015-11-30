using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class choque : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision col)
    {
        Text t= GameObject.Find("contador").GetComponent<Text>();
        int p=int.Parse(t.text);
        p++;
        GameObject.Find("contador").GetComponent<Text>().text = p.ToString();
    }
}
