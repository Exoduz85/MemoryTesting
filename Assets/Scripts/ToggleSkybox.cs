using System;
using UnityEngine;
public class ToggleSkybox : MonoBehaviour{
    private Material skybox;
    private void Start(){
        this.skybox = RenderSettings.skybox;
    }
    public void ToggleOnAndOff(){
        RenderSettings.skybox = RenderSettings.skybox == null ? this.skybox : null;
    }
    public void ToggleOnAndOffAndUnloadAssets(){
        ToggleOnAndOff();
        Resources.UnloadUnusedAssets();
    }
    public void ToggleOnAndOffAndUnloadAssetsAndGCCollect(){
        ToggleOnAndOffAndUnloadAssets();
        GC.Collect();
    }
}