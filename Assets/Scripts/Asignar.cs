using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Asignar : MonoBehaviour {

    public Color[] colores;
    public int[] numeros;
    public int[] posiciones;
    private static int tam=3; 
    // Use this for initialization
    void Start () {
        colores = new Color[tam];
        numeros = new int[tam];
        posiciones = new int[tam];
        Color[] col = new Color[5];
        int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] pos = { 0, 1, 2 };
        col[0] = Color.red;
        col[1] = Color.yellow;
        col[2] = Color.green;
        col[3] = Color.blue;
        col[4] = Color.white;
        Shuffle(col);
        Shuffle(num);
        Shuffle(pos);
        for (int i = 0; i < tam; i++)
        {
            colores[i] = col[i];
            numeros[i] = num[i];
            posiciones[i] = pos[i];
        }
        
        //GameObject.Find("Esfera2").GetComponent<Renderer>().materials[0].color = colores[1];
        //GameObject.Find("Esfera3").GetComponent<Renderer>().materials[0].color = colores[2];

    }
	
	// Update is called once per frame
	void Update () {
        InputField infi = GameObject.Find("Texto1").GetComponent<InputField>();
        ColorBlock cb = infi.colors;
        cb.normalColor = colores[0];
        cb.highlightedColor = colores[0];
        cb.pressedColor = colores[0];
        cb.disabledColor = colores[0];
        infi.colors = cb;

        infi = GameObject.Find("Texto2").GetComponent<InputField>();
        cb = infi.colors;
        cb.normalColor = colores[1];
        cb.highlightedColor = colores[1];
        cb.pressedColor = colores[1];
        cb.disabledColor = colores[1];
        infi.colors = cb;

        infi = GameObject.Find("Texto3").GetComponent<InputField>();
        cb = infi.colors;
        cb.normalColor = colores[2];
        cb.highlightedColor = colores[2];
        cb.pressedColor = colores[2];
        cb.disabledColor = colores[2];
        infi.colors = cb;
    }

    void Shuffle<T>(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            int r = (int)(Random.Range(0,n));
            T t = array[r];
            array[r] = array[i];
            array[i] = t;
        }
    }

}
