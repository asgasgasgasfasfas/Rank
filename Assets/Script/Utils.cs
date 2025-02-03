using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Utils 
{
    public enum SceneNames { Logo= 0 , Login,}
    public static string GetActiveScene()
    {
        return SceneManager.GetActiveScene().name;
    }
    public static void LoadScene(string sceneName = "")
    {
        if( sceneName == "")
        {
            SceneManager.LoadScene(GetActiveScene());
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public static void LoadScene(SceneNames sceneName)
    {
        //scenenames 열거형으로 매개변수를 받아온 경우 tostring() 처리
        SceneManager.LoadScene(sceneName.ToString());
    }
}
