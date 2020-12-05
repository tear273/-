using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public bool Startplay;

    public CollisionCheck Player1;
    public CollisionCheck Player2;

    public TileCheck TC;

    public Text P1_s, P2_s;

    public Image Timer;
    public float timer;


    private void Start()
    {
        timer = 30f;
    }

    void Update()
    {
        if(Startplay)
        {
          int p1score = TC.Red * Player1.building;
           int p2score = TC.Blue * Player2.building;

           timer -= Time.deltaTime;
           Timer.fillAmount = timer / 30f;

           P1_s.text = "Score : " + p1score;
           P2_s.text = "Score : " + p2score;

           if((int)timer <0)
           {

                if (p1score>p2score)
                {
                  WInnerCheck.Instance.SetWinner("Red");
                }
                else if (p1score < p2score)
                {
                    WInnerCheck.Instance.SetWinner("Blue");
                }
            
                SceneManager.LoadScene("Ending");
           }
        }

        
    }
}
