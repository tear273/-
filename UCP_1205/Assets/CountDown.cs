using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public Player_Controller[] player_Controller;
    public Score score;
    public AudioSource BGM;

    public void StartPlay()
    {
        player_Controller[0].startPlay = true;
        player_Controller[1].startPlay = true;
        score.Startplay = true;

        BGM.Play();

        gameObject.SetActive(false);
    }
}
