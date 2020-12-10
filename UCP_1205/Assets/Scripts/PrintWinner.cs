using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PrintWinner : MonoBehaviour
{
    public Image P1Win, P2Win, Draw;

    private void Start()
    {
        P1Win.gameObject.SetActive(false);
        P2Win.gameObject.SetActive(false);
        Draw.gameObject.SetActive(false);

        if (WInnerCheck.Instance.GetWinner()=="Red")
        {
            P1Win.gameObject.SetActive(true);
        }
        else if(WInnerCheck.Instance.GetWinner() == "Blue")
        {
            P2Win.gameObject.SetActive(true);
        }
        else
        {
            Draw.gameObject.SetActive(true);
        }
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
