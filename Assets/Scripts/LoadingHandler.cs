using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("gamePlay",3);
    }

    public void gamePlay()
    {
        GameManager.instance.SceneChange("GamePlay");  
    }
}
