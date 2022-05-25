using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;
using System.Numerics;

public class OnLogin : MonoBehaviour
{
    
    public GameObject loginFailUI;
    public GameObject loginSuccessUI;

    private void Start(){
        loginFailUI = GameObject.Find("OverlayUI/Login/Fail");
        loginSuccessUI = GameObject.Find("OverlayUI/Login/Success");
    }

    public void OnLoginSuccess() {
        User user = new User(new BigInteger(0), "");
        GameManager.instance.SetUser(user);
        loginSuccessUI.SetActive(true);
    }

    public void OnLoginFail() {
        loginFailUI.SetActive(true);
    }
}
