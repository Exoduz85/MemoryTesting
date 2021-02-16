using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public bool resoursesUnload = false;
    public bool gcCollect = false;
 
    public void LoadNext(){
        if (SceneManager.GetActiveScene().buildIndex + 1 > 5) SceneManager.LoadScene(0);
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if(resoursesUnload) Resources.UnloadUnusedAssets();
        if(gcCollect) GC.Collect();
    }
    public void ToggleUnloadAssets(){
        resoursesUnload = !resoursesUnload;
    }
    public void ToggleGCCollect(){
        gcCollect = !gcCollect;
    }
}
