using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerEX
{
    public BaseScene CurrentScene { get { return GameObject.FindObjectOfType<BaseScene>(); } }

    public void LoadScene(Define.Scene scene)
    {
        Managers.Clear();
        SceneManager.LoadScene(GetSceneName(scene));
    }

    string GetSceneName(Define.Scene scene)
    {
        string name = System.Enum.GetName(typeof(Define.Scene), scene);
        return name;
    }

    public void Clear()
    {
        CurrentScene.Clear();
    }
}
