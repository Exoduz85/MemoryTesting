using System;
using UnityEngine;

public class LoadFromResourceFolder : MonoBehaviour{
    private GameObject loadedResource;
    public bool resoursesUnload = false;
    public bool gcCollect = false;
 
    public void LoadResource(){
        if(loadedResource != null) Destroy(loadedResource);
        
        loadedResource = Instantiate(Resources.Load<GameObject>("ResourceTest"));
        
        if(resoursesUnload) Resources.UnloadUnusedAssets();
        if(gcCollect) GC.Collect();
    }

    public void LoadAnotherResource(){
        Destroy(loadedResource);
        loadedResource = Instantiate(Resources.Load<GameObject>("ResourceTestTwo"));
    }
    public void ToggleUnloadAssets(){
        resoursesUnload = !resoursesUnload;
    }
    public void ToggleGCCollect(){
        gcCollect = !gcCollect;
    }
}
// Put an asset in a Resources-Folder. Load and Instantiate it using its path. Destroy it when switching.
