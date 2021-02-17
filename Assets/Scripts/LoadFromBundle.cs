using System;
using System.IO;
using UnityEngine;

public class LoadFromBundle : MonoBehaviour{
    private GameObject loadedResource;
    private string assetName = "AssetBundleTest";
    private string bundleName = "testBundle";
    public bool resoursesUnload = false;
    public bool gcCollect = false;
 
    public void LoadResource(){
        if(loadedResource != null) Destroy(loadedResource);
        AssetBundle.UnloadAllAssetBundles(false);
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, bundleName));
        loadedResource = Instantiate(assetBundle.LoadAsset<GameObject>(assetName));
        assetBundle.Unload(false);
    }
    public void DestroyAndDoOtherStuffIfWeWantTo(){
        Destroy(loadedResource);
        if(resoursesUnload) Resources.UnloadUnusedAssets();
        if(gcCollect) GC.Collect();
    }

    public void UnloadAssetBundles(){
        AssetBundle.UnloadAllAssetBundles(true);
    }
    public void ToggleUnloadAssets(){
        resoursesUnload = !resoursesUnload;
    }
    public void ToggleGCCollect(){
        gcCollect = !gcCollect;
    }
}
// Put an asset in a Resources-Folder. Load and Instantiate it using its path. Destroy it when switching.
