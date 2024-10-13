using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInDirectionWithSpeed : MonoBehaviour {
    public float speed = 2.0f;
    public Vector3 moveDirection = new Vector3(0.0f, 1.0f, 0.0f);

    public bool useSelfSpace = true;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {   
        if (useSelfSpace) {
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        } else {
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }

        // transform.Translate(moveDirection * speed, Space.Self); // Se realiza una prueba sin Time.deltaTime (no recomendado)
    }
}
