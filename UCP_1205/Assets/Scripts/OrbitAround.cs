using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAround : MonoBehaviour
{
    public GameObject Planet;

    private void Update()
    {
        Orbit();
    }

    void Orbit()
    {
        transform.RotateAround(Planet.transform.position, new Vector3(0,1,0), 3 * Time.deltaTime);
    }
}
