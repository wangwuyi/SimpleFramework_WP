using UnityEngine;
using System.Collections;
using NLua;

public class NluaManager {
    private Lua env;

	// Use this for initialization
    public NluaManager() {
        env = new Lua();
        env.LoadCLRPackage();
        env["package.path"] = ";" + Util.LuaPath() + "?.lua;";
	}
	
	// Update is called once per frame
    public void DoFile(string file) {
        string path = Util.LuaPath() + file;
        env.DoFile(path + ".lua");
	}

    public NLua.LuaFunction GetFunction(string func) {
        return env.GetFunction(func);
    }
}
