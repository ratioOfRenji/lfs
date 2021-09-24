using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class sceneManager : MonoBehaviour
{
    private int currentSceneIndex;
    private int sceneToContinue;
    
    private void OnMouseDown()
    {
        if (gameObject.name == "купить")
        {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        if (gameObject.name == "продать")
        {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        if (gameObject.name == "vixod1")
        {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            sceneToContinue = PlayerPrefs.GetInt("SavedScene");
            SceneManager.LoadScene(0);

        }
        if (gameObject.name == "vixod2")
        {
            SceneManager.LoadScene(0);
        }
    } 
}
