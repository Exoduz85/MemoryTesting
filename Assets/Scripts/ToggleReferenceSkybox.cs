using System;
using UnityEngine;
public class ToggleReferenceSkybox : MonoBehaviour{
    public GameObject prefab;
    public void Instantiate(){
        var instance = Instantiate(prefab);
        instance.name = "NewSkyboxCamera";
    }
    public void DestroyGO(){
        Destroy(GameObject.Find("NewSkyboxCamera"));
    }
    public void ToggleOnAndOffAndUnloadAssets(){
        DestroyGO();
        Resources.UnloadUnusedAssets();
    }
    public void ToggleOnAndOffAndUnloadAssetsAndGCCollect(){
        ToggleOnAndOffAndUnloadAssets();
        GC.Collect();
    }
}