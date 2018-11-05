using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    void Start()
    {
        GenerateColor();
    }

    public void GenerateColor()
    {
        // this is referencing the shared material
        // so all objects even if its not a cube will get colorized...
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
        //Instantiating material due to calling renderer.material during edit mode. 
        //This will leak materials into the scene.You most likely want to use renderer.sharedMaterial instead.
        //GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}
