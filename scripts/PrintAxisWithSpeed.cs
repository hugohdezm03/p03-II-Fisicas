using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAxisWithSpeed : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow: " + Input.GetAxis("Vertical") * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow: " + Input.GetAxis("Vertical") * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("LeftArrow: " + Input.GetAxis("Horizontal") * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow: " + Input.GetAxis("Horizontal") * speed);
        }
        // Otra opción usando nombres de teclas (sin keycode)
        // if (Input.GetKey("up"))
        // {
        //     Debug.Log("UpArrow: " + Input.GetAxis("Vertical") * speed);
        // }
        // if (Input.GetKey("down"))
        // {
        //     Debug.Log("DownArrow: " + Input.GetAxis("Vertical") * speed);
        // }
        // if (Input.GetKey("left"))
        // {
        //     Debug.Log("LeftArrow: " + Input.GetAxis("Horizontal") * speed);
        // }
        // if (Input.GetKey("right"))
        // {
        //     Debug.Log("RightArrow: " + Input.GetAxis("Horizontal") * speed);
        // }
    }
}
