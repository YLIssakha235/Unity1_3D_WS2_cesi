using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(1);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

}


