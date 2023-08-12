using UnityEngine;

public class LevelSelectionHandler : MonoBehaviour
{
    public void navigateBack()
    {
        GameManager.instance.SceneChange("MainMenu");
    }

    public void OnLevelBtnClick(int index)
    {
        GameManager.instance.LevelSelected = index;
        GameManager.instance.SceneChange("Loading");
    }
}
