using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static User user = new User("NONE",0 );
    public static void SetUser(User _user)
    {
        Debug.Assert(user.name.Equals("NONE"), "Assert : [SetUser] already called, plz call this function only once ");
        user = _user;
    }
    public static User GetUser()
    {
        return user;
    }
    #region Betting System
    public void Bet()
    {

    }

    public void CloseBets()
    {
        //���ü�ο� ��� �� �ɾ����� ����
    }
    #endregion

    public UI_GameResultUI gameResultUI;
    public void WaitRouletteResult(bool win, float balanceChanged)
    {
        gameResultUI.gameObject.SetActive(true);
    }


}
