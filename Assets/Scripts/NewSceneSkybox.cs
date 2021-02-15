using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneSkybox : MonoBehaviour{
    public Scene reloadSkyboxScene;
    public Scene skyboxScene;
    public void ReloadLoadSkyboxScene(){
        SceneManager.LoadScene(reloadSkyboxScene.handle);
    }
    public void LoadTheSkyboxScene(){
        SceneManager.LoadScene(skyboxScene.handle);
    }
} // add a second scene to go bath and forth in, that with separate buttons that use gc and unload assets
