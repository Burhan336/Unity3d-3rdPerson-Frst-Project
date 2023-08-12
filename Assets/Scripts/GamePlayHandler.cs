using UnityEngine;

public class GamePlayHandler : MonoBehaviour
{
    public Level[] Levels;

    public GameObject ThePlayer;
    
    void Start()
    {
        Levels[GameManager.instance.LevelSelected].LevelHandler.SetActive(true);
        ThePlayer.transform.position = Levels[GameManager.instance.LevelSelected].PlayerPos.position;
    }
}

[System.Serializable]
public class Level
{
    public GameObject LevelHandler;
    public Transform PlayerPos;
}