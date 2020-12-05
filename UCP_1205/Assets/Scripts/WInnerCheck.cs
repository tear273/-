using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WInnerCheck : MonoBehaviour
{
    private static WInnerCheck instance = null;
    private string Winner;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static WInnerCheck Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    public void SetWinner(string winner)
    {
        Winner = winner;
    }

    public string GetWinner()
    {
        return Winner;
    }

}
