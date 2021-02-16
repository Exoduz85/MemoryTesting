using System;
using UnityEngine;
public class ToggleSkybox : MonoBehaviour{
    public GameObject skybox;
    public void ToggleOnAndOff(){
        skybox.SetActive(!skybox.activeSelf);
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