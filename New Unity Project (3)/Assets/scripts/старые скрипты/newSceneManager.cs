using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newSceneManager : MonoBehaviour
{
    public static newSceneManager gameSave;
    public List<ScriptableObject> objects = new List<ScriptableObject>();
    private void Awake()
    {
         if(gameSave == null)
        {
            gameSave = this;
        }
         else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this.gameObject); 
    }
}
