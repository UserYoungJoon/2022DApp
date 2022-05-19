using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI_ChipCount : MonoBehaviour
{
    public TMP_Text chipCount;
    private float eth = 0;
    //Ĩ ����� ��������? �� �̴����ߵ���?
    //�ϴ� �� 10 �̴� ���ٰ� �����ϰ� ����

    public void init()
    {
        eth = GameManager.instance.GetUser().balance;
        chipCount.text = eth.ToString();
    }

    public void UpdateCnt(float _bettingValue)
    {
        eth += _bettingValue;
        chipCount.text = "x"+eth;
    }
}
