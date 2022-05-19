using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BettingTarget : MonoBehaviour
{
    public enum eBettingType
    {
        NONE,
        RED,
        BLACK
    }

    public GameObject number = null;//�Ŀ� GameObject[]�� �ٲ㼭 ���� ����?
    public eBettingType bettingType = eBettingType.NONE;

    public UI_Betting bettingUI;
    public void Run()
    {
        Debug.Assert(bettingType != eBettingType.NONE, "Assert : betting type was [NONE]");
        bettingUI.Set(bettingType);
        bettingUI.gameObject.SetActive(true);
    }

}
