using System;
using System.IO;
using UnityEngine;

public class LoadFromBundle : MonoBehaviour{
    private GameObject loadedResource;
    private string assetName = "AssetBundleTest";
    private string bundleName = "testingbundle";
    private AssetBundle assetBundle;
    public bool resoursesUnload = false;
    public bool gcCollect = false;
 
    public void LoadResource(){
        assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, bundleName));
        Instantiate(assetBundle.LoadAsset<GameObject>(assetName));
    }
    public void DestroyAndDoOtherStuffIfWeWantTo(){
        assetBundle.Unload(true);
        Destroy(GameObject.Find("AssetBundleTest(Clone)"));
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