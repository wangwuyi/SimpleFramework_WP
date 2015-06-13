using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuaProxyDLL {
    static class PtrToInt {
        public static int ToIntPtr(this IntPtr ptr) {
            return ptr.ToInt32();
        }

        public static IntPtr ToIntPtr(this int value) {
            return new IntPtr(value);
        }
    }

    public class LuaInterop {
        public static int LuaGC(IntPtr luaState, int what, int data) {
            return 1;
        }

        public static IntPtr LuaTypeName(IntPtr luaState, int type) {
            return 1.ToIntPtr();
        }

        public static void LuaLError(IntPtr luaState, string message) {
        }

        public static void LuaLWhere(IntPtr luaState, int level) {
        }

        public static IntPtr LuaLNewState() {
            return 1.ToIntPtr();
        }

        public static void LuaClose(IntPtr luaState) {
        }

        public static void LuaLOpenLibs(IntPtr luaState) {
        }

        public static int LuaLLoadString(IntPtr luaState, string chunk) {
            return 1;
        }

        public static int LuaLLoadString(IntPtr luaState, byte[] chunk) {
            return 1;
        }

        public static void LuaCreateTable(IntPtr luaState, int narr, int nrec) {
        }

        public static void LuaGetTable(IntPtr luaState, int index) {
        }

        public static void LuaSetTop(IntPtr luaState, int newTop) {
        }

        public static void LuaInsert(IntPtr luaState, int newTop) {
        }

        public static void LuaRemove(IntPtr luaState, int index) {
        }

        public static void LuaRawGet(IntPtr luaState, int index) {
        }

        public static void LuaSetTable(IntPtr luaState, int index) {
        }

        public static void LuaRawSet(IntPtr luaState, int index) {
        }


        public static void LuaSetMetatable(IntPtr luaState, int objIndex) {
        }


        public static int LuaGetMetatable(IntPtr luaState, int objIndex) {
            return 1;
        }


        public static int LuaNetEqual(IntPtr luaState, int index1, int index2) {
            return 1;
        }


        public static void LuaPushValue(IntPtr luaState, int index) {
        }


        public static void LuaReplace(IntPtr luaState, int index) {
        }


        public static int LuaGetTop(IntPtr luaState) {
            return 1;
        }


        public static int LuaType(IntPtr luaState, int index) {
            return 1;
        }


        public static int LuaLRef(IntPtr luaState, int registryIndex) {
            return 1;
        }


        public static void LuaRawGetI(IntPtr luaState, int tableIndex, int index) {
        }


        public static void LuaRawSetI(IntPtr luaState, int tableIndex, int index) {
        }


        public static IntPtr LuaNewUserData(IntPtr luaState, uint size) {
            return 1.ToIntPtr();
        }


        public static IntPtr LuaToUserData(IntPtr luaState, int index) {
            return 1.ToIntPtr();
        }


        public static void LuaLUnref(IntPtr luaState, int registryIndex, int reference) {
        }


        public static int LuaIsString(IntPtr luaState, int index) {
            return 1;
        }


        public static int LuaIsCFunction(IntPtr luaState, int index) {
            return 1;
        }


        public static void LuaPushNil(IntPtr luaState) {
        }


        public static int LuaCall(IntPtr luaState, int nArgs, int nResults) {
            return 1;
        }


        public static int LuaNetPCall(IntPtr luaState, int nArgs, int nResults, int errfunc) {
            return 1;
        }


        public static IntPtr LuaToCFunction(IntPtr luaState, int index) {
            return 1.ToIntPtr();
        }


        public static double LuaNetToNumber(IntPtr luaState, int index) {
            return 1;
        }

        public static int LuaToBoolean(IntPtr luaState, int index) {
            return 1;
        }

        public static IntPtr LuaToLString(IntPtr luaState, int index, out uint strLen) {
            strLen = 0;
            return 1.ToIntPtr();
        }

        public static void LuaAtPanic(IntPtr luaState, IntPtr panicf) {
        }

        public static void LuaPushStdCallCFunction(IntPtr luaState, IntPtr function) {
        }

        public static void LuaPushNumber(IntPtr luaState, double number) {
        }

        public static void LuaPushBoolean(IntPtr luaState, int value) {
        }

        public static void LuaNetPushLString(IntPtr luaState, string str, uint size) {
        }

        public static void LuaPushString(IntPtr luaState, string str) {
        }

        public static int LuaLNewMetatable(IntPtr luaState, string meta) {
            return 1;
        }

        public static void LuaGetField(IntPtr luaState, int stackPos, string meta) {
        }

        public static IntPtr LuaLCheckUData(IntPtr luaState, int stackPos, string meta) {
            return 1.ToIntPtr(); 
        }

        public static int LuaLGetMetafield(IntPtr luaState, int stackPos, string field) {
            return 1;
        }

        public static int LuaNetLoadBuffer(IntPtr luaState, string buff, uint size, string name) {
            return 1;
        }

        public static int LuaNetLoadBuffer(IntPtr luaState, byte[] buff, uint size, string name) {
            return 1;
        }

        public static int LuaNetLoadFile(IntPtr luaState, string filename) {
            return 1;
        }

        public static void LuaError(IntPtr luaState) {
        }

        public static int LuaCheckStack(IntPtr luaState, int extra) {
            return 1;
        }

        public static int LuaNext(IntPtr luaState, int index) {
            return 1;
        }

        public static void LuaPushLightUserData(IntPtr luaState, IntPtr udata) {
        }

        public static int LuaLCheckMetatable(IntPtr luaState, int obj) {
            return 1;
        }

        public static int LuaGetHookMask(IntPtr luaState) {
            return 1;
        }

        public static int LuaSetHook(IntPtr luaState, IntPtr func, int mask, int count) {
            return 1;
        }

        public static int LuaGetHookCount(IntPtr luaState) {
            return 1;
        }

        public static IntPtr LuaGetLocal(IntPtr luaState, IntPtr ar, int n) {
            return 0.ToIntPtr();
        }

        public static IntPtr LuaSetLocal(IntPtr luaState, IntPtr ar, int n) {
            return 0.ToIntPtr();
        }

        public static IntPtr LuaGetUpValue(IntPtr luaState, int funcindex, int n) {
            return 0.ToIntPtr();
        }

        public static IntPtr LuaSetUpValue(IntPtr luaState, int funcindex, int n) {
            return 0.ToIntPtr();
        }

        public static int LuaNetToNetObject(IntPtr luaState, int index) {
            return 1;
        }

        public static void LuaNetNewUData(IntPtr luaState, int val) {
        }

        public static int LuaNetRawNetObj(IntPtr luaState, int obj) {
            return 1;
        }

        public static int LuaNetCheckUData(IntPtr luaState, int ud, string tname) {
            return 1;
        }

        public static IntPtr LuaNetGetTag() {
            return 1.ToIntPtr();
        }

        public static void LuaNetPushGlobalTable(IntPtr luaState) {
        }

        public static void LuaNetPopGlobalTable(IntPtr luaState) {
        }

        public static void LuaNetGetGlobal(IntPtr luaState, string name) {
        }

        public static void LuaNetSetGlobal(IntPtr luaState, string name) {
        }

        public static int LuaNetRegistryIndex() {
            return 1;
        }

        public static IntPtr LuaNetGetMainState(IntPtr luaState) {
            return 1.ToIntPtr();
        }

        public static int LuaGetInfo(IntPtr luaState, string what, IntPtr ar) {
            return 1;
        }

        public static int LuaGetStack(IntPtr luaState, int level, IntPtr n) {
            return 1;
        }

        public static int LuaNetIsStringStrict(IntPtr luaState, int index) {
            return 1;
        }
    }
}
