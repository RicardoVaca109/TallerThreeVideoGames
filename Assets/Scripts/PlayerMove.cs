using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour 
{
    
    public int playerSpeed = 10;
    public ChangeColor changeColorComponent;
    public ChangeColorTwo changeColorTwoComponent;
    //public ChangeColor colorCambio;
    void Start()
    {
        changeColorComponent = GameObject.FindObjectOfType<ChangeColor>();
        changeColorTwoComponent = GameObject.FindObjectOfType<ChangeColorTwo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right* playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            changeColorComponent.colorChangeBlack();
            changeColorTwoComponent.colorChangeCyan();
        }
        if (Input.GetKey(KeyCode.E))
        {
            changeColorComponent.colorChangeGreen();
            changeColorTwoComponent.colorChangeRed();
        }
        if (Input.GetKey(KeyCode.R))
        {
            changeColorComponent.colorChangeGray();
            changeColorTwoComponent.colorChangeBlue();
        }
        if (Input.GetKey(KeyCode.F))
        {
            changeColorComponent.colorChangeGreen();
            changeColorTwoComponent.colorChangeBlack();
        }
    }
    
}
