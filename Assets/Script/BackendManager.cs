using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BackEnd; //�ڳ� sdk

public class BackendManager : MonoBehaviour
{

    private void Awake()
    {
        //Update() �޼ҵ��� backend.AsyncPoll ȣ���� ���� ������Ʈ�� �İ����� �ʴ´�
        DontDestroyOnLoad(gameObject);
        // �ڳ� ���� �ʱ�ȭ
        BackendSetup();
    }
    private void Update()
    {
        //������ �񵿱� �޼ҵ� ȣ�� �ݹ� �Լ� Ǯ���� ���� �ۼ�
        if(Backend.IsInitialized)
        {
            Backend.AsyncPoll();
        }
    }
    private void BackendSetup()
    {
        //�ڳ� �ʱ�ȭ
        var bro = Backend.Initialize(true);

        //�ڳ� �ʱ�ȭ�� ���� ���䰪
        if (bro.IsSuccess())
        {
            //�ʱ�ȭ ������ statusCode 204 Success
            Debug.Log($"�ʱ�ȭ ���� : {bro}");
        }
        else
        {
            //�ʱ�ȭ ���н� statusCode 400 �� ���� �߻�
            Debug.LogError($"�ʱ�ȭ ���� : {bro}");
        }
    }
}
