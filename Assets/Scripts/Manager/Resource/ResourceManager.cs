using UnityEngine;
using System.Collections;
using System.IO;

public class ResourceManager : MonoBehaviour {
    private AssetBundle shared;

    void Awake() {
        initialize();
    }
	
    /// <summary>
    /// 初始化
    /// </summary>
    void initialize() {
        string uri = string.Empty;
        //------------------------------------Shared--------------------------------------
        uri = Util.DataPath + "shared.assetbundle";
        Debug.LogWarning("LoadFile::>> " + uri);

        shared = AssetBundle.CreateFromFile(uri);
        shared.Load("Dialog", typeof(GameObject));
        ioo.gameManager.OnResourceInited();    //回调游戏管理器，执行后续操作 
    }

    /// <summary>
    /// 载入素材
    /// </summary>
    public AssetBundle LoadBundle(string name) {
        AssetBundle bundle = null;
        string uri = Util.DataPath + name.ToLower() + ".assetbundle";
        bundle = AssetBundle.CreateFromFile(uri); //关联数据的素材绑定
        return bundle;
    }

    /// <summary>
    /// 销毁资源
    /// </summary>
    void OnDestroy() {
        if (shared != null) shared.Unload(true);
        Debug.Log("~ResourceManager was destroy!");
    }
}
