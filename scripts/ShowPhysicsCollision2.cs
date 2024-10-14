using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPhysicsCollision2 : MonoBehaviour
{
    public float cubeSpeed = 5.0f;
    private GameObject cube;
    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cube_direction = new Vector3(Input.GetAxis("New Arrows Horizontal"), Input.GetAxis("New Arrows Vertical"), 0.0f);
        cube.transform.Translate(cube_direction * cubeSpeed * Time.deltaTime, Space.Self);
    }
}
