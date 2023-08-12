using UnityEngine;


public class StartLoadingHandler : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadingHandler",3);
    }
    public void LoadingHandler()
    {
       GameManager.instance.SceneChange("MainMenu");
    }
}
