using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneSkybox : MonoBehaviour{
    public void LoadSeparateScene(){
        SceneManager.LoadScene("SeparateScene");
    }
    public void LoadAdditiveScene(){
        SceneManager.LoadScene("AdditiveScene", LoadSceneMode.Additive);
    }
    public void UnLoadAdditiveScene(){
        SceneManager.UnloadSceneAsync("AdditiveScene");
    }
    public void UnLoadAdditiveSceneAndUnusedAssets(){
        Resources.UnloadUnusedAssets();
        UnLoadAdditiveScene();
    }
    public void UnLoadAdditiveSceneAndUnusedAssetsAndGCCollect(){
        GC.Collect();
        UnLoadAdditiveSceneAndUnusedAssets();
    }
    public void ReloadTheSkyboxScene(){
        SceneManager.LoadScene("NewSceneSkybox");
    }
    public void ReloadTheSkyboxSceneAndUnusedAssets(){
        Resources.UnloadUnusedAssets();
        ReloadTheSkyboxScene();
    }
    public void ReloadTheSkyboxSceneAndUnusedAssetsAndGCCollect(){
        GC.Collect();
        ReloadTheSkyboxSceneAndUnusedAssets();
    }
}
