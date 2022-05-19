using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    #region Setting
    private GameManager() { }
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private User user = new User("NONE", 0);
    public void SetUser(User _user)
    {
        Debug.Assert(user.name.Equals("NONE"), "Assert : [SetUser] already called, plz call this function only once ");
        user = _user;
        chipCountUI.init();
    }
    public User GetUser()
    {
        return user;
    }
    #endregion

    #region Betting System

    public UI_ChipCount chipCountUI;
    private BettingTarget.eBettingType bettingType;
    private float bettingValue;
    public void SetBetType(BettingTarget.eBettingType _bettingType)
    {
        bettingType = _bettingType;
    }

    public void Bet(float _bettingValue)
    {
        //UI update 
        bettingValue = _bettingValue;
        // _bettingValue, bettingType�� ���ü������ ����(how?)

        gameState = eGameState.WAITING_GAME_RESULT;
    }
    #endregion

    public UI_GameResultUI gameResultUI;
    public void WaitRouletteResult(bool _win, float _balanceChanged)
    {//await? async?
        gameResultUI.gameObject.SetActive(true);
    }


    private enum eGameState { BETTING, WAITING_GAME_RESULT, REWARDING }
    private eGameState gameState = eGameState.BETTING;
    private void Update()
    {
        switch (gameState)
        {
            case eGameState.BETTING:
                //���� ������ ����
                //�׳� Block UI�� �۵� ���ϴ� ���¶�� �����ϸ� ��
                //ClostBetting�ϸ� Waiting state�� switch
                break;
            case eGameState.WAITING_GAME_RESULT:
                //��ȣ �� ������ �귿 �������ֱ�
                // RotateRoulette();
                // if (WaitSingal()) ��ȣ accept�ϸ� Rewardig���� switch
                gameResultUI.ResultSettingBy(bettingValue);//���ü�ο��� ���� ������ �����ؾߵ�. �ϴ� �׳� ������
                gameResultUI.gameObject.SetActive(true);
                gameState = eGameState.REWARDING;
                break;
            case eGameState.REWARDING:
                //������ �ް� ���û��·� switch�ϱ�
                //������ â ���� �� ������ �ȵ� block UI �ʿ�
                // RewardUI.Close�ϸ� ���� ���·� switch
                break;
        }

    }
    public void SwitchGameStateToBetting()
    {//Ĩ ī��Ʈ ������, Ĩ GameObject ġ���, 
     //chipCountUI.UpdateCnt( ... ); ����� Update
        gameState = eGameState.BETTING;
    }
}
