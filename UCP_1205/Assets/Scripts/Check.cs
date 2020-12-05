using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Red,
    Blue,
    None
}

public class Check : MonoBehaviour
{
    public State state;

    public Renderer CheckRenderer;

    public TileCheck tileCheck;
    public Material Ground;

    void Start()
    {
        CheckRenderer = GetComponent<Renderer>();
        state = State.None;

        GroundCheck();
    }

    void GroundCheck()
    {
        if (CheckRenderer.materials.Length == 5)
        {
            Ground = CheckRenderer.materials[2];

            if(Ground.name != "36 GREEN (Instance)")
            {
                Ground = CheckRenderer.materials[1];
            }
        }
        else
        {
            Ground = CheckRenderer.materials[0];
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"&&(state==State.None||state ==State.Blue))
        {

            Ground.color = new Color32(202, 48, 56, 255);
            state = State.Red;
            
            tileCheck.Red++;
            
        }
        if (collision.gameObject.tag == "Player2" && (state == State.None || state == State.Red))
        {
            Ground.color = new Color32(52, 76, 120, 255);
            state = State.Blue;
            
            tileCheck.Blue++;
        }
    }
}
