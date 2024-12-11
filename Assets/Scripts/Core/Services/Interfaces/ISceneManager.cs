using UnityEngine.SceneManagement;

public class SceneLoader
{
    public void LoadScene(SceneInfo scene)
    {
        SceneManager.LoadScene(scene.sceneName);
    }

    public void UnloadScene(SceneInfo scene)
    {
        SceneManager.UnloadScene(scene.sceneName);
    }
}

public struct SceneInfo
{
    public string sceneName;

    public SceneInfo(string newSceneName)
    {
        sceneName = newSceneName;
    }
}