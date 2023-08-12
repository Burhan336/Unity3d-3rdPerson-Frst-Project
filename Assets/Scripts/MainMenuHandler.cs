using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    public void Play()
    {
      GameManager.instance.SceneChange("LevelSelection");  
    }
}
