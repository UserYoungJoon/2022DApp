using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GameResultCloseBtn : MonoBehaviour
{
    private GameManager gameManager;
    public UI_GameResultUI gameResultUI;
    public void Start()
    {
        gameManager = GameManager.instance;
    }

    public void Run()
    {
        //������ �ް� ���û��·� switch�ϱ�
        //������ â ���� �� ������ �ȵ� block UI �ʿ�
        // RewardUI.Close�ϸ� ���� ���·� switch
        gameManager.SwitchGameStateToBetting();
        gameResultUI.gameObject.SetActive(false);
    }
}
