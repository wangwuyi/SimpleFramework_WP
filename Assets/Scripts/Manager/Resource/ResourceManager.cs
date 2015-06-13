using UnityEngine;
using System.Collections;
using System.IO;

public class ResourceManager : MonoBehaviour {
    private AssetBundle shared;

    void Awake() {
        initialize();
    }
	
    /// <summary>
    /// ��ʼ��
    /// </summary>
    void initialize() {
        string uri = string.Empty;
        //------------------------------------Shared--------------------------------------
        uri = Util.DataPath + "shared.assetbundle";
        Debug.LogWarning("LoadFile::>> " + uri);

        shared = AssetBundle.CreateFromFile(uri);
        shared.Load("Dialog", typeof(GameObject));
        ioo.gameManager.OnResourceInited();    //�ص���Ϸ��������ִ�к������� 
    }

    /// <summary>
    /// �����ز�
    /// </summary>
    public AssetBundle LoadBundle(string name) {
        AssetBundle bundle = null;
        string uri = Util.DataPath + name.ToLower() + ".assetbundle";
        bundle = AssetBundle.CreateFromFile(uri); //�������ݵ��زİ�
        return bundle;
    }

    /// <summary>
    /// ������Դ
    /// </summary>
    void OnDestroy() {
        if (shared != null) shared.Unload(true);
        Debug.Log("~ResourceManager was destroy!");
    }
}
