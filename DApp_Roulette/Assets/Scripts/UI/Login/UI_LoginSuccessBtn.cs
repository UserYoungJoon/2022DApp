using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoginSuccessBtn : MonoBehaviour
{
    public GameObject loginUI;
    public GameObject chipCnt;
    public void Run()
    {
        //���Ѵٸ� ���⼭ �α��� ���� �޽��� �ٲ��� �� ����
        chipCnt.SetActive(true);
        loginUI.SetActive(false);
    }
}
