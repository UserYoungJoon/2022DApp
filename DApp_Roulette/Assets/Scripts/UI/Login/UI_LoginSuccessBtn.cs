using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoginSuccessBtn : MonoBehaviour
{
    public GameObject loginUI;
    public void Run()
    {
        //���Ѵٸ� ���⼭ �α��� ���� �޽��� �ٲ��� �� ����
        loginUI.SetActive(false);
    }
}
