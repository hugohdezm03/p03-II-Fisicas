using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMoveWithSpeedUpgraded : MonoBehaviour
{
    public float speed = 5.0f;
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
        Vector3 cube_direction = new Vector3(Input.GetAxis("New Arrows Horizontal"), Input.GetAxis("New Arrows Vertical"), 0.0f);
        Vector3 sphere_direction = new Vector3(Input.GetAxis("New Letters Horizontal"), Input.GetAxis("New Letters Vertical"), 0.0f);
        cube.transform.Translate(cube_direction * speed * Time.deltaTime, Space.Self);
        sphere.transform.Translate(sphere_direction * speed * Time.deltaTime, Space.Self);
    }
}
