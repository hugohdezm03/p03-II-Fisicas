using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPhysicCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log($"Trigger detected with ${collider.gameObject.name}.");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision detected with ${collision.gameObject.name}.");
    }
}
