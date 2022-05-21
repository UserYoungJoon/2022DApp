using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_LoginBtn : MonoBehaviour
{
    public GameObject loginFailUI;
    public GameObject loginSuccessUI;
    
    public void Run()
    {
        //�α��� ����
        if (TryLogIn()) //�α��� ���������� �α��� �ý��� ����.
        {
            //����� �α׾ƿ��Ͽ� �ٽ� �α��� �޴��� ���ƿ� �� ����.
            loginSuccessUI.SetActive(true);
        }
        else //�α��� ����
        {//�α��� ���� UI �����ֱ�
            loginFailUI.SetActive(true);
        }
    }

    private bool TryLogIn()
    {
        User user = new User( -1 );
        bool loginSucceed = false;
        
        if(true)
        {
            //[DApp1] metamask�� �α���
            //awiat ����ص� �ǰ� ���ص� �˴ϴ�
            //�����ϸ� false return
        }

        GameManager.instance.SetUser(user);
        return loginSucceed;
    }
}
