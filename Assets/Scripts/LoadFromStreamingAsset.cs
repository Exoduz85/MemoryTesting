using System;
using UnityEngine;
using System.IO;
using UnityEngine.Networking;

public class LoadFromStreamingAsset : MonoBehaviour{
    private GameObject loadedResource;
    public bool resoursesUnload = false;
    public bool gcCollect = false;
 
    public void LoadResource(){
        if(loadedResource != null) Destroy(loadedResource);
        
        /*
        Material mat = new Material(Shader.Find("Skybox/Cubemap"));
        var cubeTexture2D = DownloadHandlerTexture.GetContent(UnityWebRequestTexture.GetTexture(Application.persistentDataPath + "/StreamingAssets/AssetOnePNG.png"));
        Cubemap cubemap = new Cubemap(128, TextureFormat.RGBA32, false);
        */
        
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
// StreamingAssets
// Put an asset in a StreamingAssets-Folder. Load and Instantiate it using it path. Destroy it when switching.

