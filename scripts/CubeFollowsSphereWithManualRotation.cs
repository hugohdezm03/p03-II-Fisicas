using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFollowsSphereWithManualRotation : MonoBehaviour
{
    public float sphereSpeed = 5.0f;
    public float cubeSpeed = 3.0f;
    public float rotationSpeed = 10.0f;
    private GameObject cube;
    private GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        sphere = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sphere_direction = new Vector3(Input.GetAxis("New Letters Horizontal"), Input.GetAxis("New Letters Vertical"), 0.0f);
        sphere.transform.Translate(sphere_direction * sphereSpeed * Time.deltaTime, Space.Self);
        
        Vector3 cube_direction = Vector3.Normalize(sphere.transform.position - cube.transform.position);
        // Rotate the cube to face the sphere
        cube.transform.rotation = Quaternion.Slerp(cube.transform.rotation, Quaternion.LookRotation(sphere.transform.position - cube.transform.position), Time.deltaTime * rotationSpeed);

        Debug.DrawRay(cube.transform.position, cube.transform.forward, Color.green);
        cube.transform.Translate(cube_direction * cubeSpeed * Time.deltaTime, Space.World);
    }
}
