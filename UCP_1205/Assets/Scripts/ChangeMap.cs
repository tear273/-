using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMap : MonoBehaviour
{
    public GameObject Map1, Map2;
    public float timer = 3f;

    private void Start()
    {
        Map1.SetActive(true);
        Map2.SetActive(false);
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <0)
        {
            if (Map1.activeSelf)
            {
                Map1.SetActive(false);
                Map2.SetActive(true);
                timer = 3f;
            }
            else
            {
                Map1.SetActive(true);
                Map2.SetActive(false);
                timer = 3f;
            }

        }
    }
}
