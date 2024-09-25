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
            Debug.Log("초기화 성공" + bro);
            LoginTest();
        }
        else
        {
            Debug.LogError("초기화 실패" + bro);
        }
    }

    void Update()
    {
        
    }

    void Test()
    {
        ServerLogin.Instance.CustomSignUp("user1", "1234");
        Debug.Log("테스트");
    }

    void LoginTest()
    {
        ServerLogin.Instance.CustomLogin("user1", "1234");
        Debug.Log("로그인 테스트");
    }
}
