using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Numerics;

public class UI_BettingBtn : MonoBehaviour
{
    public GameObject ErrorUI;
    public TMP_InputField bettingValue;
    public UI_Betting bettingUI;
    public User user;

    private void Start()
    {
        user = GameManager.instance.GetUser();
    }

    public void Bet()
    {
        BigInteger tryBetting = BigInteger.Parse(bettingValue.text);//.Parse(bettingValue.text);
        if (tryBetting > 0 /* && user.balance > tryBetting */)
        {
            GameManager.instance.Bet(tryBetting);
            bettingUI.gameObject.SetActive(false);
        }
        else
        {
            ErrorUI.SetActive(true);
        }
    }
}
