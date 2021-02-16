using System;
using UnityEngine;
public class InstantiatePrefabSkybox : MonoBehaviour{
    public GameObject[] skyBoxCameras;
    public GameObject currentSkybox;
    public int currentIndex;
    public bool resoursesUnload = false;
    public bool gcCollect = false;
    private void Start(){
        DestroyGO();
    }
    public void Instantiate(){
        currentIndex++;
        if (currentIndex > 5) currentIndex = 0;
        DestroyGO();
    }
    public void DestroyGO(){
        if(currentSkybox != null) Destroy(this.currentSkybox);
        this.currentSkybox = Instantiate(this.skyBoxCameras[this.currentIndex]);
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