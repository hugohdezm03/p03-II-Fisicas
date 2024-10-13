using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMoveWithSpeedUpgraded : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.Translate(direction * speed * Time.deltaTime, Space.Self);
    }
}
