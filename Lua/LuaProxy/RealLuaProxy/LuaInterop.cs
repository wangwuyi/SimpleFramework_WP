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
            return lua52.Interop.LuaGC(luaState.ToIntPtr(), what, data);
        }

        public static IntPtr LuaTypeName(IntPtr luaState, int type) {
            return lua52.Interop.LuaTypeName(luaState.ToIntPtr(), type).ToIntPtr();
        }

        public static void LuaLError(IntPtr luaState, string message) {
            lua52.Interop.LuaLError(luaState.ToIntPtr(), message);
        }

        public static void LuaLWhere(IntPtr luaState, int level) {
            lua52.Interop.LuaLWhere(luaState.ToIntPtr(), level);
        }

        public static IntPtr LuaLNewState() {
            return lua52.Interop.LuaLNewState().ToIntPtr();
        }

        public static void LuaClose(IntPtr luaState) {
            lua52.Interop.LuaClose(luaState.ToIntPtr());
        }

        public static void LuaLOpenLibs(IntPtr luaState) {
            lua52.Interop.LuaLOpenLibs(luaState.ToIntPtr());
        }

        public static int LuaLLoadString(IntPtr luaState, string chunk) {
            return lua52.Interop.LuaLLoadString(luaState.ToIntPtr(), chunk);
        }

        public static int LuaLLoadString(IntPtr luaState, byte[] chunk) {
            return lua52.Interop.LuaLLoadStringArray(luaState.ToIntPtr(), chunk);
        }

        public static void LuaCreateTable(IntPtr luaState, int narr, int nrec) {
            lua52.Interop.LuaCreateTable(luaState.ToIntPtr(), narr, nrec);
        }

        public static void LuaGetTable(IntPtr luaState, int index) {
            lua52.Interop.LuaGetTable(luaState.ToIntPtr(), index);
        }

        public static void LuaSetTop(IntPtr luaState, int newTop) {
            lua52.Interop.LuaSetTop(luaState.ToIntPtr(), newTop);
        }

        public static void LuaInsert(IntPtr luaState, int newTop) {
            lua52.Interop.LuaInsert(luaState.ToIntPtr(), newTop);
        }

        public static void LuaRemove(IntPtr luaState, int index) {
            lua52.Interop.LuaRemove(luaState.ToIntPtr(), index);
        }

        public static void LuaRawGet(IntPtr luaState, int index) {
            lua52.Interop.LuaRawGet(luaState.ToIntPtr(), index);
        }

        public static void LuaSetTable(IntPtr luaState, int index) {
            lua52.Interop.LuaSetTable(luaState.ToIntPtr(), index);
        }

        public static void LuaRawSet(IntPtr luaState, int index) {
            lua52.Interop.LuaRawSet(luaState.ToIntPtr(), index);
        }


        public static void LuaSetMetatable(IntPtr luaState, int objIndex) {
            lua52.Interop.LuaSetMetatable(luaState.ToIntPtr(), objIndex);
        }


        public static int LuaGetMetatable(IntPtr luaState, int objIndex) {
            return lua52.Interop.LuaGetMetatable(luaState.ToIntPtr(), objIndex);
        }


        public static int LuaNetEqual(IntPtr luaState, int index1, int index2) {
            return lua52.Interop.LuaNetEqual(luaState.ToIntPtr(), index1, index2);
        }


        public static void LuaPushValue(IntPtr luaState, int index) {
            lua52.Interop.LuaPushValue(luaState.ToIntPtr(), index);
        }


        public static void LuaReplace(IntPtr luaState, int index) {
            lua52.Interop.LuaReplace(luaState.ToIntPtr(), index);
        }


        public static int LuaGetTop(IntPtr luaState) {
            return lua52.Interop.LuaGetTop(luaState.ToIntPtr());
        }


        public static int LuaType(IntPtr luaState, int index) {
            return lua52.Interop.LuaType(luaState.ToIntPtr(), index);
        }


        public static int LuaLRef(IntPtr luaState, int registryIndex) {
            return lua52.Interop.LuaLRef(luaState.ToIntPtr(), registryIndex);
        }


        public static void LuaRawGetI(IntPtr luaState, int tableIndex, int index) {
            lua52.Interop.LuaRawGetI(luaState.ToIntPtr(), tableIndex, index);
        }


        public static void LuaRawSetI(IntPtr luaState, int tableIndex, int index) {
            lua52.Interop.LuaRawSetI(luaState.ToIntPtr(), tableIndex, index);
        }


        public static IntPtr LuaNewUserData(IntPtr luaState, uint size) {
            return lua52.Interop.LuaNewUserData(luaState.ToIntPtr(), size).ToIntPtr();
        }


        public static IntPtr LuaToUserData(IntPtr luaState, int index) {
            return lua52.Interop.LuaToUserData(luaState.ToIntPtr(), index).ToIntPtr();
        }


        public static void LuaLUnref(IntPtr luaState, int registryIndex, int reference) {
            lua52.Interop.LuaLUnref(luaState.ToIntPtr(), registryIndex, reference);
        }


        public static int LuaIsString(IntPtr luaState, int index) {
            return lua52.Interop.LuaIsString(luaState.ToIntPtr(), index);
        }


        public static int LuaIsCFunction(IntPtr luaState, int index) {
            return lua52.Interop.LuaIsCFunction(luaState.ToIntPtr(), index);
        }


        public static void LuaPushNil(IntPtr luaState) {
            lua52.Interop.LuaPushNil(luaState.ToIntPtr());
        }


        public static int LuaCall(IntPtr luaState, int nArgs, int nResults) {
            return lua52.Interop.LuaCall(luaState.ToIntPtr(), nArgs, nResults);
        }


        public static int LuaNetPCall(IntPtr luaState, int nArgs, int nResults, int errfunc) {
            return lua52.Interop.LuaNetPCall(luaState.ToIntPtr(), nArgs, nResults, errfunc);
        }


        public static IntPtr LuaToCFunction(IntPtr luaState, int index) {
            return lua52.Interop.LuaToCFunction(luaState.ToIntPtr(), index).ToIntPtr();
        }


        public static double LuaNetToNumber(IntPtr luaState, int index) {
            return lua52.Interop.LuaNetToNumber(luaState.ToIntPtr(), index);
        }

        public static int LuaToBoolean(IntPtr luaState, int index) {
            return lua52.Interop.LuaToBoolean(luaState.ToIntPtr(), index);
        }

        public static IntPtr LuaToLString(IntPtr luaState, int index, out uint strLen) {
            return lua52.Interop.LuaToLString(luaState.ToIntPtr(), index, out strLen).ToIntPtr();
        }

        public static void LuaAtPanic(IntPtr luaState, IntPtr panicf) {
            lua52.Interop.LuaAtPanic(luaState.ToIntPtr(), panicf.ToIntPtr());
        }

        public static void LuaPushStdCallCFunction(IntPtr luaState, IntPtr function) {
            lua52.Interop.LuaPushStdCallCFunction(luaState.ToIntPtr(), function.ToIntPtr());
        }

        public static void LuaPushNumber(IntPtr luaState, double number) {
            lua52.Interop.LuaPushNumber(luaState.ToIntPtr(), number);
        }

        public static void LuaPushBoolean(IntPtr luaState, int value) {
            lua52.Interop.LuaPushBoolean(luaState.ToIntPtr(), value);
        }

        public static void LuaNetPushLString(IntPtr luaState, string str, uint size) {
            lua52.Interop.LuaNetPushLString(luaState.ToIntPtr(), str, size);
        }

        public static void LuaPushString(IntPtr luaState, string str) {
            lua52.Interop.LuaPushString(luaState.ToIntPtr(), str);
        }

        public static int LuaLNewMetatable(IntPtr luaState, string meta) {
            return lua52.Interop.LuaLNewMetatable(luaState.ToIntPtr(), meta);
        }

        public static void LuaGetField(IntPtr luaState, int stackPos, string meta) {
            lua52.Interop.LuaGetField(luaState.ToIntPtr(), stackPos, meta);
        }

        public static IntPtr LuaLCheckUData(IntPtr luaState, int stackPos, string meta) {
            return lua52.Interop.LuaLCheckUData(luaState.ToIntPtr(), stackPos, meta).ToIntPtr();
        }

        public static int LuaLGetMetafield(IntPtr luaState, int stackPos, string field) {
            return lua52.Interop.LuaLGetMetafield(luaState.ToIntPtr(), stackPos, field);
        }

        public static int LuaNetLoadBuffer(IntPtr luaState, string buff, uint size, string name) {
            return lua52.Interop.LuaNetLoadBuffer(luaState.ToIntPtr(), buff, size, name);
        }

        public static int LuaNetLoadBuffer(IntPtr luaState, byte[] buff, uint size, string name) {
            return lua52.Interop.LuaNetLoadBufferArray(luaState.ToIntPtr(), buff, size, name);
        }

        public static int LuaNetLoadFile(IntPtr luaState, string filename) {
            return lua52.Interop.LuaNetLoadFile(luaState.ToIntPtr(), filename);
        }

        public static void LuaError(IntPtr luaState) {
            lua52.Interop.LuaError(luaState.ToIntPtr());
        }

        public static int LuaCheckStack(IntPtr luaState, int extra) {
            return lua52.Interop.LuaCheckStack(luaState.ToIntPtr(), extra);
        }

        public static int LuaNext(IntPtr luaState, int index) {
            return lua52.Interop.LuaNext(luaState.ToIntPtr(), index);
        }

        public static void LuaPushLightUserData(IntPtr luaState, IntPtr udata) {
            lua52.Interop.LuaPushLightUserData(luaState.ToIntPtr(), udata.ToIntPtr());
        }

        public static int LuaLCheckMetatable(IntPtr luaState, int obj) {
            return lua52.Interop.LuaLCheckMetatable(luaState.ToIntPtr(), obj);
        }

        public static int LuaGetHookMask(IntPtr luaState) {
            return lua52.Interop.LuaGetHookMask(luaState.ToIntPtr());
        }

        public static int LuaSetHook(IntPtr luaState, IntPtr func, int mask, int count) {
            return lua52.Interop.LuaSetHook(luaState.ToIntPtr(), func.ToIntPtr(), mask, count);
        }

        public static int LuaGetHookCount(IntPtr luaState) {
            return lua52.Interop.LuaGetHookCount(luaState.ToIntPtr());
        }

        public static IntPtr LuaGetLocal(IntPtr luaState, IntPtr ar, int n) {
            return lua52.Interop.LuaGetLocal(luaState.ToIntPtr(), ar.ToIntPtr(), n).ToIntPtr();
        }

        public static IntPtr LuaSetLocal(IntPtr luaState, IntPtr ar, int n) {
            return lua52.Interop.LuaSetLocal(luaState.ToIntPtr(), ar.ToIntPtr(), n).ToIntPtr();
        }

        public static IntPtr LuaGetUpValue(IntPtr luaState, int funcindex, int n) {
            return lua52.Interop.LuaGetUpValue(luaState.ToIntPtr(), funcindex, n).ToIntPtr();
        }

        public static IntPtr LuaSetUpValue(IntPtr luaState, int funcindex, int n) {
            return lua52.Interop.LuaSetUpValue(luaState.ToIntPtr(), funcindex, n).ToIntPtr();
        }

        public static int LuaNetToNetObject(IntPtr luaState, int index) {
            return lua52.Interop.LuaNetToNetObject(luaState.ToIntPtr(), index);
        }

        public static void LuaNetNewUData(IntPtr luaState, int val) {
            lua52.Interop.LuaNetNewUData(luaState.ToIntPtr(), val);
        }

        public static int LuaNetRawNetObj(IntPtr luaState, int obj) {
            return lua52.Interop.LuaNetRawNetObj(luaState.ToIntPtr(), obj);
        }

        public static int LuaNetCheckUData(IntPtr luaState, int ud, string tname) {
            return lua52.Interop.LuaNetCheckUData(luaState.ToIntPtr(), ud, tname);
        }

        public static IntPtr LuaNetGetTag() {
            return lua52.Interop.LuaNetGetTag().ToIntPtr();
        }

        public static void LuaNetPushGlobalTable(IntPtr luaState) {
            lua52.Interop.LuaNetPushGlobalTable(luaState.ToIntPtr());
        }

        public static void LuaNetPopGlobalTable(IntPtr luaState) {
            lua52.Interop.LuaNetPopGlobalTable(luaState.ToIntPtr());
        }

        public static void LuaNetGetGlobal(IntPtr luaState, string name) {
            lua52.Interop.LuaNetGetGlobal(luaState.ToIntPtr(), name);
        }

        public static void LuaNetSetGlobal(IntPtr luaState, string name) {
            lua52.Interop.LuaNetSetGlobal(luaState.ToIntPtr(), name);
        }

        public static int LuaNetRegistryIndex() {
            return lua52.Interop.LuaNetRegistryIndex();
        }

        public static IntPtr LuaNetGetMainState(IntPtr luaState) {
            return lua52.Interop.LuaNetGetMainState(luaState.ToIntPtr()).ToIntPtr();
        }

        public static int LuaGetInfo(IntPtr luaState, string what, IntPtr ar) {
            return lua52.Interop.LuaGetInfo(luaState.ToIntPtr(), what, ar.ToIntPtr());
        }

        public static int LuaGetStack(IntPtr luaState, int level, IntPtr n) {
            return lua52.Interop.LuaGetStack(luaState.ToIntPtr(), level, n.ToIntPtr());
        }

        public static int LuaNetIsStringStrict(IntPtr luaState, int index) {
            return lua52.Interop.LuaNetIsStringStrict(luaState.ToIntPtr(), index);
        }
    }
}
