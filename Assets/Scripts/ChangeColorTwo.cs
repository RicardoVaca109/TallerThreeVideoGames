using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorTwo : MonoBehaviour
{
    public Renderer objectRendtwo;
    public Color initialcolor = Color.white;
    void Start()
    {
        objectRendtwo = GetComponent<Renderer>();
        objectRendtwo.material.color = initialcolor;
        
    }

    public void colorChangeBlack()
    {
        objectRendtwo.material.color = Color.black;
    }
    public void colorChangeCyan()
    {
        objectRendtwo.material.color = Color.cyan;
    }
    public void colorChangeRed()
    {
        objectRendtwo.material.color = Color.red;
    }
    public void colorChangeGreen()
    {
        objectRendtwo.material.color = Color.green;
    }
    public void colorChangeBlue()
    {
        objectRendtwo.material.color = Color.blue;
    }
    public void colorChangeGray()
    {
        objectRendtwo.material.color = Color.gray;
    }
}
