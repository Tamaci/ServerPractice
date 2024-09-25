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
            Debug.Log("ȸ�����Կ� �����߽��ϴ�" + bro);
        }
        else
        {
            Debug.LogError("ȸ�����Կ� �����߽��ϴ�." + bro);
        }
    }

    public void CustomLogin(string id, string pw)
    {
        Debug.Log("�α����� ��û�մϴ�");

        var bro = Backend.BMember.CustomLogin(id, pw);

        if(bro.IsSuccess())
        {
            Debug.Log("�α��ο� �����߽��ϴ�" + bro);
        }
        else
        {
            Debug.LogError("�α��ο� �����߽��ϴ�" + bro);
        }
    }
    
    public void UpdateNickname(string nickname)
    {

    }
}
