using System;
using UnityEngine;
public class ToggleReferenceSkybox : MonoBehaviour{
    public GameObject[] skyBoxCameras;
    public GameObject currentSkybox;
    public int currentIndex;

    private void Start(){
        InstantiateNext();
    }
    public void InstantiateNext(){
        this.currentSkybox = Instantiate(this.skyBoxCameras[this.currentIndex++]);
    }
    public void DestroyGO(){
        Destroy(this.currentSkybox);
    }
    public void UnloadAssetsAndDestroy(){
        DestroyGO();
        InstantiateNext();
        Resources.UnloadUnusedAssets();
    }
    public void UnloadAssetsAndDestroyAndGCCollect(){
        UnloadAssetsAndDestroy();
        GC.Collect();
    }
}