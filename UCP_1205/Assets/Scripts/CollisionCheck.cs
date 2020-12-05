using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCheck : MonoBehaviour
{
    public int building;
    public GameObject Partical;
    public AudioSource effect;
    
    public void OnTriggerEnter(Collider other)
    {
        effect.Play();
        switch(other.gameObject.transform.parent.name)
        {
            case "A":
                building += 2;
                effect.pitch = 0.8f;
                break;
            case "B":
                building += 2;
                effect.pitch = 0.8f;
                break;
            case "C":
                building += 3;
                effect.pitch = 0.9f;
                break;
            case "D":
                building += 3;
                effect.pitch = 0.9f;
                break;
            case "E":
                building += 2;
                effect.pitch = 0.8f;
                break;
            case "F":
                building += 2;
                effect.pitch = 0.8f;
                break;
            case "G":
                building += 2;
                effect.pitch = 0.8f;
                break;
            case "Middle_A":
                building += 5;
                effect.pitch = 1;
                break;
            case "Middle_B":
                building += 5;
                effect.pitch = 1;
                break;
            case "Middle_C":
                building += 5;
                effect.pitch = 1;
                break;
            case "Nature":
                building += 1;
                effect.pitch = 0.7f;
                break;
        }

        Destroy(other.gameObject);
        Instantiate(Partical, transform.position, transform.rotation);
    }
}
