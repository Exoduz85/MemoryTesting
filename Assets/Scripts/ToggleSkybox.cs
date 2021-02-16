using System;
using UnityEngine;
public class ToggleSkybox : MonoBehaviour{
    public GameObject[] skyBoxCameras;
    public int currentIndex;
    public bool resoursesUnload = false;
    public bool gcCollect = false;

    public void ToggleOnAndOff(){
        this.skyBoxCameras[this.currentIndex].SetActive(!this.skyBoxCameras[this.currentIndex].activeSelf);
        if(resoursesUnload) Resources.UnloadUnusedAssets();
        if(gcCollect) GC.Collect();
    }
    public void MoveNext(){
        if(this.skyBoxCameras[currentIndex].activeSelf) this.skyBoxCameras[currentIndex].SetActive(false);
        currentIndex++;
        if (currentIndex > 5) currentIndex = 5;
        SetCurrentSkybox();
    }
    public void MoveBack(){
        if(this.skyBoxCameras[currentIndex].activeSelf) this.skyBoxCameras[currentIndex].SetActive(false);
        currentIndex--;
        if (currentIndex < 0) currentIndex = 0;
        SetCurrentSkybox();
    }
    public void ToggleUnloadAssets(){
        resoursesUnload = !resoursesUnload;
    }
    public void ToggleGCCollect(){
        gcCollect = !gcCollect;
    }
    void SetCurrentSkybox(){
        this.skyBoxCameras[currentIndex].SetActive(true);
    }
}