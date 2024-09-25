using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BackEnd;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        var bro = Backend.Initialize();

        if (bro.IsSuccess())
        {
            Debug.Log("�ʱ�ȭ ����" + bro);
            LoginTest();
        }
        else
        {
            Debug.LogError("�ʱ�ȭ ����" + bro);
        }
    }

    void Update()
    {
        
    }

    void Test()
    {
        ServerLogin.Instance.CustomSignUp("user1", "1234");
        Debug.Log("�׽�Ʈ");
    }

    void LoginTest()
    {
        ServerLogin.Instance.CustomLogin("user1", "1234");
        Debug.Log("�α��� �׽�Ʈ");
    }
}
