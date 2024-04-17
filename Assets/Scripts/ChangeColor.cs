using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Variable para almacenar el componente Renderer del objeto
    public Renderer objectRenderer;

    // Color inicial del objeto
    public Color initialColor = Color.white;

    void Start()
    {
        // Obtener el componente Renderer del objeto
        objectRenderer = GetComponent<Renderer>();

        // Establecer el color inicial
        objectRenderer.material.color = initialColor;
    }

    // Update is called once per frame
    public void colorChangeBlack() 
    {
       objectRenderer.material.color =Color.black;
    }
    public void colorChangeCyan()
    {
        objectRenderer.material.color = Color.cyan;
    }
    public void colorChangeRed()
    {
        objectRenderer.material.color = Color.red;
    }
    public void colorChangeGreen()
    {
        objectRenderer.material.color = Color.green;
    }
    public void colorChangeBlue()
    {
        objectRenderer.material.color = Color.blue;
    }
    public void colorChangeGray()
    {
        objectRenderer.material.color = Color.gray;
    }
}
