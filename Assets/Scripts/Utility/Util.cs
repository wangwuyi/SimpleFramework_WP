using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Util : MonoBehaviour {
    public static int Int(object o) {
        return Convert.ToInt32(o); 
    }

    public static float Float(object o) {
        return (float)Math.Round(Convert.ToSingle(o), 2);
    }

    public static long Long(object o) {
        return Convert.ToInt64(o);
    }

    public static int Random(int min, int max) {
        return UnityEngine.Random.Range(min, max);
    }

    public static float Random(float min, float max) {
        return UnityEngine.Random.Range(min, max);
    }

    public static string Uid(string uid) {
        int position = uid.LastIndexOf('_');
        return uid.Remove(0, position + 1);
    }

    public static long GetTime() { 
        TimeSpan ts = new TimeSpan(DateTime.UtcNow.Ticks - new DateTime(1970, 1, 1, 0, 0, 0).Ticks);
        return (long)ts.TotalMilliseconds;
    }

    /// <summary>
    /// 搜索子物体组件-GameObject版
    /// </summary>
    public static T Get<T>(GameObject go, string subnode) where T : Component {
        if (go != null) {
            Transform sub = go.transform.FindChild(subnode);
            if (sub != null) return sub.GetComponent<T>();
        }
        return null;
    }

    /// <summary>
    /// 搜索子物体组件-Transform版
    /// </summary>
    public static T Get<T>(Transform go, string subnode) where T : Component {
        if (go != null) {
            Transform sub = go.FindChild(subnode);
            if (sub != null) return sub.GetComponent<T>();
        }
        return null;
    }

    /// <summary>
    /// 搜索子物体组件-Component版
    /// </summary>
    public static T Get<T>(Component go, string subnode) where T : Component {
        return go.transform.FindChild(subnode).GetComponent<T>();
    }

    /// <summary>
    /// 添加组件
    /// </summary>
    public static T Add<T>(GameObject go) where T : Component {
        if (go != null) {
            T[] ts = go.GetComponents<T>();
            for (int i = 0; i < ts.Length; i++ ) {
                if (ts[i] != null) Destroy(ts[i]);
            }
            return go.gameObject.AddComponent<T>();
        }
        return null;
    }

    /// <summary>
    /// 添加组件
    /// </summary>
    public static T Add<T>(Transform go) where T : Component {
        return Add<T>(go.gameObject);
    }

    /// <summary>
    /// 查找子对象
    /// </summary>
    public static GameObject Child(GameObject go, string subnode) {
        return Child(go.transform, subnode);
    }

    /// <summary>
    /// 查找子对象
    /// </summary>
    public static GameObject Child(Transform go, string subnode) {
        Transform tran = go.FindChild(subnode);
        if (tran == null) return null;
        return tran.gameObject;
    }

    /// <summary>
    /// 取平级对象
    /// </summary>
    public static GameObject Peer(GameObject go, string subnode) {
        return Peer(go.transform, subnode);
    }

    /// <summary>
    /// 取平级对象
    /// </summary>
    public static GameObject Peer(Transform go, string subnode) {
        Transform tran = go.parent.FindChild(subnode);
        if (tran == null) return null;
        return tran.gameObject;
    }

    /// <summary>
    /// 手机震动
    /// </summary>
    public static void Vibrate() {
        //int canVibrate = PlayerPrefs.GetInt(Const.AppPrefix + "Vibrate", 1);
        //if (canVibrate == 1) iPhoneUtils.Vibrate();
    }

    /// <summary>
    /// 判断数字
    /// </summary>
    public static bool IsNumeric(string str) {
        if (str == null || str.Length == 0) return false;
        for (int i = 0; i < str.Length; i++ ) {
            if (!Char.IsNumber(str[i])) { return false; }
        }
        return true;
    }

    /// <summary>
    /// 清除所有子节点
    /// </summary>
    public static void ClearChild(Transform go) {
        if (go == null) return;
        for (int i = go.childCount - 1; i >= 0; i--) {
            Destroy(go.GetChild(i).gameObject);
        }
    }

    /// <summary>
    /// 生成一个Key名
    /// </summary>
    public static string GetKey(string key) {
        return Const.AppPrefix + Const.UserId + "_" + key; 
    }

    /// <summary>
    /// 取得整型
    /// </summary>
    public static int GetInt(string key) {
        string name = GetKey(key);
        return PlayerPrefs.GetInt(name);
    }

    /// <summary>
    /// 有没有值
    /// </summary>
    public static bool HasKey(string key) {
        string name = GetKey(key);
        return PlayerPrefs.HasKey(name);
    }

    /// <summary>
    /// 保存整型
    /// </summary>
    public static void SetInt(string key, int value) {
        string name = GetKey(key);
        PlayerPrefs.DeleteKey(name);
        PlayerPrefs.SetInt(name, value);
    }

    /// <summary>
    /// 取得数据
    /// </summary>
    public static string GetString(string key) {
        string name = GetKey(key);
        return PlayerPrefs.GetString(name);
    }

    /// <summary>
    /// 保存数据
    /// </summary>
    public static void SetString(string key, string value) {
        string name = GetKey(key);
        PlayerPrefs.DeleteKey(name);
        PlayerPrefs.SetString(name, value);
    }

    /// <summary>
    /// 删除数据
    /// </summary>
    public static void RemoveData(string key) {
        string name = GetKey(key);
        PlayerPrefs.DeleteKey(name);
    }

    /// <summary>
    /// 清理内存
    /// </summary>
    public static void ClearMemory() {
        GC.Collect(); Resources.UnloadUnusedAssets();
    }

    /// <summary>
    /// 取得数据存放目录
    /// </summary>
    public static string DataPath {
        get {
            string game = Const.AppName.ToLower();
            if (Application.platform == RuntimePlatform.IPhonePlayer || 
                Application.platform == RuntimePlatform.Android ||
                Application.platform == RuntimePlatform.WP8Player) {
                return Application.persistentDataPath + "/" + game + "/";
            } 
            if (Const.DebugMode) {
                string target = "wp8player";
                return Application.dataPath + "/StreamingAssets/" + target + "/";
            }
            return "c:/" + game + "/";
        }
    }

    /// <summary>
    /// 网络可用v   
    /// </summary>
    public static bool NetAvailable {
        get {
            return Application.internetReachability != NetworkReachability.NotReachable;
        }
    }

    /// <summary>
    /// 是否是无线
    /// </summary>
    public static bool IsWifi {
        get {
            return Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork;
        }
    }

    /// <summary>
    /// 应用程序内容路径
    /// </summary>
    public static string AppContentPath() {
        string path = string.Empty;
        switch (Application.platform) {
            case RuntimePlatform.Android:
                path = "jar:file://" + Application.dataPath + "!/assets/android";
            break;
            case RuntimePlatform.IPhonePlayer:
                path = Application.dataPath + "/Raw/iphone";
            break;
            case RuntimePlatform.WP8Player:
                path = Application.dataPath + "/StreamingAssets/wp8player";
            break;
            default:
                path = Application.dataPath + "/StreamingAssets/wp8player";
            break;
        }
        return path;
    }

    /// <summary>
    /// 是否是登录场景
    /// </summary>
    public static bool isLogin {
        get { return Application.loadedLevelName.CompareTo("login") == 0; }
    }

    /// <summary>
    /// 是否是城镇场景
    /// </summary>
    public static bool isMain {
        get { return Application.loadedLevelName.CompareTo("main") == 0; }
    }

    /// <summary>
    /// 判断是否是战斗场景
    /// </summary>
    public static bool isFight {
        get { return Application.loadedLevelName.CompareTo("fight") == 0; }
    }

    public static string LuaPath() {
        if (Const.DebugMode) {
            return Application.dataPath + "/lua/";
        }
        return DataPath + "lua/"; 
    }

    /// <summary>
    /// 取得Lua路径
    /// </summary>
    public static string LuaPath(string name) {
        if (name.EndsWith(".lua")) {
            return DataPath + "lua/" + name;
        }
        return DataPath + "lua/" + name + ".lua";
    }

    public static void Log(string str) {
        Debug.Log(str);
    }

    public static void LogWarning(string str) {
        Debug.LogWarning(str);
    }

    public static void LogError(string str) {
        Debug.LogError(str); 
    }

    public static void WriteAllBytes(string path, byte[] data) {
        using (FileStream fs = File.OpenWrite(path)) {
            BinaryWriter writer = new BinaryWriter(fs);
            writer.Write(data);
            writer.Close();
        }
    }

    public static string[] ReadAllLines(string path) {
        List<string> lines = new List<string>();
        using (FileStream fs = File.OpenRead(path)) {
            StreamReader reader = new StreamReader(fs);
            while (!reader.EndOfStream) {
                lines.Add(reader.ReadLine());
            }
            reader.Close();
        }
        return lines.ToArray();
    }
}