using BackEnd;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerLogin
{
    private static ServerLogin _instance = null;

    public static ServerLogin Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ServerLogin();
            }

            return _instance;
        }
    }

    public void CustomSignUp(string id, string pw)
    {
        var bro = Backend.BMember.CustomSignUp(id, pw);

        if (bro.IsSuccess())
        {
            Debug.Log("회원가입에 성공했습니다" + bro);
        }
        else
        {
            Debug.LogError("회원가입에 실패했습니다." + bro);
        }
    }

    public void CustomLogin(string id, string pw)
    {
        Debug.Log("로그인을 요청합니다");

        var bro = Backend.BMember.CustomLogin(id, pw);

        if(bro.IsSuccess())
        {
            Debug.Log("로그인에 성공했습니다" + bro);
        }
        else
        {
            Debug.LogError("로그인에 실패했습니다" + bro);
        }
    }
    
    public void UpdateNickname(string nickname)
    {

    }
}
