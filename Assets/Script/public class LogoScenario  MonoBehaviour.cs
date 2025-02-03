using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScenario : MonoBehaviour
{
    [SerializeField]
    private Progress progress;
    [SerializeField]
    private SceneNames nextScene;
    private void Awake()
    {
        SystemSetUp();

    }
    private void SystemSetUp()
    {
        //Ȱ��ȭ ���� ���� ���¿����� ������ ��� ����
        Application.runInBackground = true;
        //�ػ� ���� 
        int width = Screen.width;
        int height = (int)(Screen.width * 18.5f / 9);
        Screen.SetResolution(width, height, true);

        //ȭ���� ������ �ʵ��� ����
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        //�ε� �ִϸ��̼� ���� ��� �Ϸ�� onAfterProgress() �޼ҵ� ����
        progress.Play(OnAfterProgress);
    }
    private void OnAfterProgress()
    {
        Utils.LoadScene(nextScene);
    }
}
