using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    #region Setting
    private GameManager() { }
    private void Awake()
    {
        if (instance != null)
        {
            instance = new GameManager();
        }
    }
    private User user = new User("NONE", 0);
    public void SetUser(User _user)
    {
        Debug.Assert(user.name.Equals("NONE"), "Assert : [SetUser] already called, plz call this function only once ");
        user = _user;
    }
    public User GetUser()
    {
        return user;
    }
    #endregion

    #region Betting System
    public void Bet(BettingTarget.eBettingType _bettingType)
    {
        // ���ü������ ������ ��� �󸶳� ���� �𸣰���
    }

    public void CloseBets()
    {
        //���ü�ο� ��� �� �ɾ����� ����
        //await�ϰ� update ���鼭 ������ ������ ��ٸ��� ������ ���� Ȥ�� �����ϰ� ��ٸ���
        // ���� ���� �� �ʿ�
    }
    #endregion

    public UI_GameResultUI gameResultUI;
    public void WaitRouletteResult(bool win, float balanceChanged)
    {//await? async?
        gameResultUI.gameObject.SetActive(true);
    }

    private enum eGameState 
    { 
        BETTING,
        WAITING
    }

}
