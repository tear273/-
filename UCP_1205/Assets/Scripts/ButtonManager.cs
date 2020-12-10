using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject canvas;
    public bool Menu;
    public Text[] Txt;
    public int rand;

    private void Start()
    {
        rand = Random.Range(0, 2);

        if (!Menu)
        {
            Txt = canvas.GetComponentsInChildren<Text>();
            for (int i = 4; i < 8; i++)
            {
                Txt[i].gameObject.SetActive(false);
            }
        }


    }
    public void GameStart()
    {
        if(rand == 1)
        {
            SceneManager.LoadScene("Map3");
        }
        else
        {
            SceneManager.LoadScene("Map2");
        }
        
    }

    public void Explain()
    {
        SceneManager.LoadScene("ExplainScene");
    }

    public void ExitPlace()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Next()
    {
        for(int i=0;i<Txt.Length;i++)
        {
            if(Txt[i].name =="txt")
            {
                if(Txt[i].gameObject.activeSelf)
                {
                    Txt[i].gameObject.SetActive(false);
                }
                else
                {
                    Txt[i].gameObject.SetActive(true);
                }
            }
        }


    }
}
