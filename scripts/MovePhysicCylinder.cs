using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePhysicCylinder : MonoBehaviour
{
    public float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // Se usarán las letras asdw para mover el nuevo cilindro
        Vector3 direction = new Vector3(Input.GetAxis("New Letters Horizontal"), Input.GetAxis("New Letters Vertical"), 0.0f);
        GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Force);
    }
}
