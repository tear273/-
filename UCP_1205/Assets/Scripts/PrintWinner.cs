using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PrintWinner : MonoBehaviour
{
    public Text P1Win, P2Win;

    private void Start()
    {
        P1Win.gameObject.SetActive(false);
        P2Win.gameObject.SetActive(false);

        if(WInnerCheck.Instance.GetWinner()=="Red")
        {
            P1Win.gameObject.SetActive(true);
        }
        else
        {
            P2Win.gameObject.SetActive(true);
        }
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
