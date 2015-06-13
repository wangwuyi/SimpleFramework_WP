using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using LuaProxyDLL;

namespace KeraLua
{

#if UNITY_WP8 && !UNITY_EDITOR
    class NativeMethods
   	{
        internal static  int LuaGC (IntPtr luaState, int what, int data)
        {
            return LuaInterop.LuaGC(luaState, what, data);
        }
        
        internal static IntPtr LuaTypeName (IntPtr luaState, int type)
        {
            return LuaInterop.LuaTypeName(luaState, type);
        }

        internal static void LuaLError(IntPtr luaState, string message)
        {
            LuaInterop.LuaLError(luaState, message);
        }

        internal static void LuaLWhere(IntPtr luaState, int level)
        {
            LuaInterop.LuaLWhere(luaState, level);
        }

        internal static IntPtr LuaLNewState()
        {
            return LuaInterop.LuaLNewState();
        }

        internal static void LuaClose(IntPtr luaState)
        {
            LuaInterop.LuaClose(luaState);
        }

        internal static void LuaLOpenLibs(IntPtr luaState)
        {
            LuaInterop.LuaLOpenLibs(luaState);
        }

        internal static int LuaLLoadString(IntPtr luaState, string chunk)
        {
            return LuaInterop.LuaLLoadString(luaState, chunk);
        }

        internal static int LuaLLoadString(IntPtr luaState, byte [] chunk)
        {
            return LuaInterop.LuaLLoadString(luaState, chunk);
        }

        internal static void LuaCreateTable(IntPtr luaState, int narr, int nrec)
        {
            LuaInterop.LuaCreateTable(luaState, narr, nrec);
        }

        internal static void LuaGetTable(IntPtr luaState, int index)
        {
            LuaInterop.LuaGetTable(luaState, index);
        }
        
        internal static void LuaSetTop(IntPtr luaState, int newTop)
        {
            LuaInterop.LuaSetTop(luaState, newTop);
        }

        internal static void LuaInsert(IntPtr luaState, int newTop)
        {
            LuaInterop.LuaInsert(luaState, newTop);
        }
        
        internal static void LuaRemove(IntPtr luaState, int index)
        {
            LuaInterop.LuaRemove(luaState, index);
        }

        internal static void LuaRawGet(IntPtr luaState, int index)
        {
            LuaInterop.LuaRawGet(luaState, index);
        }

        internal static void LuaSetTable(IntPtr luaState, int index)
        {
            LuaInterop.LuaSetTable(luaState, index);
        }

        internal static void LuaRawSet(IntPtr luaState, int index)
        {
            LuaInterop.LuaRawSet(luaState, index);
        }


        internal static void LuaSetMetatable(IntPtr luaState, int objIndex)
        {
            LuaInterop.LuaSetMetatable(luaState, objIndex);
        }


        internal static int LuaGetMetatable(IntPtr luaState, int objIndex)
        {
            return LuaInterop.LuaGetMetatable(luaState, objIndex);
        }


        internal static int LuaNetEqual(IntPtr luaState, int index1, int index2)
        {
            return LuaInterop.LuaNetEqual(luaState, index1, index2);
        }


        internal static void LuaPushValue(IntPtr luaState, int index)
        {
            LuaInterop.LuaPushValue(luaState, index);
        }


        internal static void LuaReplace(IntPtr luaState, int index)
        {
            LuaInterop.LuaReplace(luaState, index);
        }


        internal static int LuaGetTop(IntPtr luaState)
        {
            return LuaInterop.LuaGetTop(luaState);
        }


        internal static int LuaType(IntPtr luaState, int index)
        {
            return LuaInterop.LuaType(luaState, index);
        }


        internal static int LuaLRef(IntPtr luaState, int registryIndex)
        {
            return LuaInterop.LuaLRef(luaState, registryIndex);
        }


        internal static void LuaRawGetI(IntPtr luaState, int tableIndex, int index)
        {
            LuaInterop.LuaRawGetI(luaState, tableIndex, index);
        }


        internal static void LuaRawSetI(IntPtr luaState, int tableIndex, int index)
        {
            LuaInterop.LuaRawSetI(luaState, tableIndex, index);
        }


        internal static IntPtr LuaNewUserData(IntPtr luaState, uint size)
        {
            return LuaInterop.LuaNewUserData(luaState, size);
        }


        internal static IntPtr LuaToUserData(IntPtr luaState, int index)
        {
            return LuaInterop.LuaToUserData(luaState, index);
        }


        internal static void LuaLUnref(IntPtr luaState, int registryIndex, int reference)
        {
            LuaInterop.LuaLUnref(luaState, registryIndex, reference);
        }


        internal static int LuaIsString(IntPtr luaState, int index)
        {
            return LuaInterop.LuaIsString(luaState, index);
        }

        internal static int LuaNetIsStringStrict(IntPtr luaState, int index) 
        {
            return LuaInterop.LuaNetIsStringStrict(luaState, index);
        }

        internal static int LuaIsCFunction(IntPtr luaState, int index)
        {
            return LuaInterop.LuaIsCFunction(luaState, index);
        }


        internal static void LuaPushNil(IntPtr luaState)
        {
            LuaInterop.LuaPushNil(luaState);
        }


        internal static int LuaCall(IntPtr luaState, int nArgs, int nResults)
        {
            return LuaInterop.LuaCall(luaState, nArgs, nResults);
        }


        internal static int LuaNetPCall(IntPtr luaState, int nArgs, int nResults, int errfunc)
        {
            return LuaInterop.LuaNetPCall(luaState, nArgs, nResults, errfunc);
        }


        internal static IntPtr LuaToCFunction(IntPtr luaState, int index)
        {
            return LuaInterop.LuaToCFunction(luaState, index);
        }


        internal static double LuaNetToNumber(IntPtr luaState, int index)
        {
            return LuaInterop.LuaNetToNumber(luaState, index);
        }

        internal static int LuaToBoolean(IntPtr luaState, int index)
        {
            return LuaInterop.LuaToBoolean(luaState, index);
        }

        internal static IntPtr LuaToLString(IntPtr luaState, int index, out uint strLen)
        {
            return LuaInterop.LuaToLString(luaState, index, out strLen);
        }
        
        internal static void LuaAtPanic(IntPtr luaState, IntPtr panicf)
        {
            LuaInterop.LuaAtPanic(luaState, panicf);
        }
        
        internal static void LuaPushStdCallCFunction(IntPtr luaState, IntPtr function)
        {
            LuaInterop.LuaPushStdCallCFunction(luaState, function);
        }
        
        internal static void LuaPushNumber(IntPtr luaState, double number)
        {
            LuaInterop.LuaPushNumber(luaState, number);
        }
        
        internal static void LuaPushBoolean(IntPtr luaState, int value)
        {
            LuaInterop.LuaPushBoolean(luaState, value);
        }
        
        internal static void LuaNetPushLString(IntPtr luaState, string str, uint size)
        {
            LuaInterop.LuaNetPushLString(luaState, str, size);
        }
        
        internal static void LuaPushString(IntPtr luaState, string str)
        {
            LuaInterop.LuaPushString(luaState, str);
        }
        
        internal static int LuaLNewMetatable(IntPtr luaState, string meta)
        {
            return LuaInterop.LuaLNewMetatable(luaState, meta);
        }

        internal static void LuaGetField(IntPtr luaState, int stackPos, string meta)
        {
            LuaInterop.LuaGetField(luaState, stackPos, meta);
        }

        internal static IntPtr LuaLCheckUData(IntPtr luaState, int stackPos, string meta)
        {
            return LuaInterop.LuaLCheckUData(luaState, stackPos, meta);
        }

        internal static int LuaLGetMetafield(IntPtr luaState, int stackPos, string field)
        {
            return LuaInterop.LuaLGetMetafield(luaState, stackPos, field);
        }

        internal static int LuaNetLoadBuffer(IntPtr luaState, string buff, uint size, string name)
        {
            return LuaInterop.LuaNetLoadBuffer(luaState, buff, size, name);
        }

        internal static int LuaNetLoadBuffer(IntPtr luaState, byte [] buff, uint size, string name)
        {
            return LuaInterop.LuaNetLoadBuffer(luaState, buff, size, name);
        }

        internal static int LuaNetLoadFile(IntPtr luaState, string filename)
        {
            return LuaInterop.LuaNetLoadFile(luaState, filename);
        }

        internal static void LuaError(IntPtr luaState)
        {
            LuaInterop.LuaError(luaState);
        }

        internal static int LuaCheckStack(IntPtr luaState, int extra)
        {
            return LuaInterop.LuaCheckStack(luaState, extra);
        }
		
		internal static  int LuaNext (IntPtr luaState, int index)
        {
            return LuaInterop.LuaNext(luaState, index);
        }

        internal static void LuaPushLightUserData(IntPtr luaState, IntPtr udata)
        {
            LuaInterop.LuaPushLightUserData(luaState, udata);
        }

        internal static int LuaLCheckMetatable(IntPtr luaState, int obj)
        {
            return LuaInterop.LuaLCheckMetatable(luaState, obj);
        }

        internal static int LuaGetHookMask(IntPtr luaState)
        {
            return LuaInterop.LuaGetHookMask(luaState);
        }

        internal static int LuaSetHook(IntPtr luaState, IntPtr func, int mask, int count)
        {
            return LuaInterop.LuaSetHook(luaState, func, mask, count);
        }

        internal static int LuaGetHookCount(IntPtr luaState)
        {
            return LuaInterop.LuaGetHookCount(luaState);
        }

        internal static int LuaGetInfo(IntPtr luaState, string what, IntPtr ar) 
        {
            return LuaInterop.LuaGetInfo(luaState, what, ar);
        }

        internal static int LuaGetStack(IntPtr luaState, int level, IntPtr n) 
        {
            return LuaInterop.LuaGetStack(luaState, level, n);
        }

        internal static IntPtr LuaGetLocal(IntPtr luaState, IntPtr ar, int n)
        {
            return LuaInterop.LuaGetLocal(luaState, ar, n);
        }

        internal static IntPtr LuaSetLocal(IntPtr luaState, IntPtr ar, int n)
        {
            return LuaInterop.LuaSetLocal(luaState, ar, n);
        }

        internal static IntPtr LuaGetUpValue(IntPtr luaState, int funcindex, int n)
        {
            return LuaInterop.LuaGetUpValue(luaState, funcindex, n);
        }

        internal static IntPtr LuaSetUpValue(IntPtr luaState, int funcindex, int n)
        {
            return LuaInterop.LuaSetUpValue(luaState, funcindex, n);
        }

        internal static int LuaNetToNetObject(IntPtr luaState, int index)
        {
            return LuaInterop.LuaNetToNetObject(luaState, index);
        }

        internal static void LuaNetNewUData(IntPtr luaState, int val)
        {
            LuaInterop.LuaNetNewUData(luaState, val);
        }

        internal static int LuaNetRawNetObj(IntPtr luaState, int obj)
        {
            return LuaInterop.LuaNetRawNetObj(luaState, obj);
        }

        internal static int LuaNetCheckUData(IntPtr luaState, int ud, string tname)
        {
            return LuaInterop.LuaNetCheckUData(luaState, ud, tname);
        }

        internal static IntPtr LuaNetGetTag()
        {
            return LuaInterop.LuaNetGetTag();
        }

        internal static void LuaNetPushGlobalTable(IntPtr luaState)
        {
            LuaInterop.LuaNetPushGlobalTable(luaState);
        }

        internal static void LuaNetPopGlobalTable(IntPtr luaState)
        {
            LuaInterop.LuaNetPopGlobalTable(luaState);
        }

        internal static void LuaNetGetGlobal(IntPtr luaState, string name)
        {
            LuaInterop.LuaNetGetGlobal(luaState, name);
        }

        internal static void LuaNetSetGlobal(IntPtr luaState, string name)
        {
            LuaInterop.LuaNetSetGlobal(luaState, name);
        }

        internal static int LuaNetRegistryIndex()
        {
            return LuaInterop.LuaNetRegistryIndex();
        }

		internal static IntPtr LuaNetGetMainState(IntPtr luaState)
		{
			return LuaInterop.LuaNetGetMainState(luaState);
		}
	}

#else
    static class NativeMethods {

#if MONOTOUCH
		const string LIBNAME = "__Internal";
#else
#if DEBUGLUA
		const string LIBNAME = "lua52d";
#else
        const string LIBNAME = "lua52";
#endif

#if USE_DYNAMIC_DLL_REGISTER
		static NativeMethods ()
		{
			DynamicLibraryPath.RegisterPathForDll (LIBNAME);
		}
#endif

#endif

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_gc")]
        internal static extern int LuaGC(IntPtr luaState, int what, int data);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_typename")]
        internal static extern IntPtr LuaTypeName(IntPtr luaState, int type);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luaL_error")]
        internal static extern void LuaLError(IntPtr luaState, string message);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luaL_where")]
        internal static extern void LuaLWhere(IntPtr luaState, int level);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luaL_newstate")]
        internal static extern IntPtr LuaLNewState();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_close")]
        internal static extern void LuaClose(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luaL_openlibs")]
        internal static extern void LuaLOpenLibs(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luaL_loadstring")]
        internal static extern int LuaLLoadString(IntPtr luaState, string chunk);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luaL_loadstring")]
        internal static extern int LuaLLoadString(IntPtr luaState, byte[] chunk);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_createtable")]
        internal static extern void LuaCreateTable(IntPtr luaState, int narr, int nrec);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_gettable")]
        internal static extern void LuaGetTable(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_settop")]
        internal static extern void LuaSetTop(IntPtr luaState, int newTop);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_insert")]
        internal static extern void LuaInsert(IntPtr luaState, int newTop);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_remove")]
        internal static extern void LuaRemove(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_rawget")]
        internal static extern void LuaRawGet(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_settable")]
        internal static extern void LuaSetTable(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_rawset")]
        internal static extern void LuaRawSet(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_setmetatable")]
        internal static extern void LuaSetMetatable(IntPtr luaState, int objIndex);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_getmetatable")]
        internal static extern int LuaGetMetatable(IntPtr luaState, int objIndex);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_equal")]
        internal static extern int LuaNetEqual(IntPtr luaState, int index1, int index2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_pushvalue")]
        internal static extern void LuaPushValue(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_replace")]
        internal static extern void LuaReplace(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_gettop")]
        internal static extern int LuaGetTop(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_type")]
        internal static extern int LuaType(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luaL_ref")]
        internal static extern int LuaLRef(IntPtr luaState, int registryIndex);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_rawgeti")]
        internal static extern void LuaRawGetI(IntPtr luaState, int tableIndex, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_rawseti")]
        internal static extern void LuaRawSetI(IntPtr luaState, int tableIndex, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_newuserdata")]
        internal static extern IntPtr LuaNewUserData(IntPtr luaState, uint size);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_touserdata")]
        internal static extern IntPtr LuaToUserData(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luaL_unref")]
        internal static extern void LuaLUnref(IntPtr luaState, int registryIndex, int reference);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_isstring")]
        internal static extern int LuaIsString(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_isstring_strict")]
        internal static extern int LuaNetIsStringStrict(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_iscfunction")]
        internal static extern int LuaIsCFunction(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_pushnil")]
        internal static extern void LuaPushNil(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_pcall")]
        internal static extern int LuaNetPCall(IntPtr luaState, int nArgs, int nResults, int errfunc);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_tocfunction")]
        internal static extern IntPtr LuaToCFunction(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_tonumber")]
        internal static extern double LuaNetToNumber(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_toboolean")]
        internal static extern int LuaToBoolean(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_atpanic")]
        internal static extern void LuaAtPanic(IntPtr luaState, IntPtr panicf);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_pushstdcallcfunction")]
        internal static extern void LuaPushStdCallCFunction(IntPtr luaState, IntPtr function);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_pushnumber")]
        internal static extern void LuaPushNumber(IntPtr luaState, double number);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_pushboolean")]
        internal static extern void LuaPushBoolean(IntPtr luaState, int value);


        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_tolstring")]
        internal static extern IntPtr LuaToLString(IntPtr luaState, int index, out uint strLen);

#if WSTRING
		[DllImport (LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "luanet_pushlwstring")]
#else
        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luanet_pushlstring")]
#endif
        internal static extern void LuaNetPushLString(IntPtr luaState, string str, uint size);

#if WSTRING
		[DllImport (LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "luanet_pushwstring")]
#else
        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "lua_pushstring")]
#endif
        internal static extern void LuaPushString(IntPtr luaState, string str);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luaL_newmetatable")]
        internal static extern int LuaLNewMetatable(IntPtr luaState, string meta);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "lua_getfield")]
        internal static extern void LuaGetField(IntPtr luaState, int stackPos, string meta);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luaL_checkudata")]
        internal static extern IntPtr LuaLCheckUData(IntPtr luaState, int stackPos, string meta);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luaL_getmetafield")]
        internal static extern int LuaLGetMetafield(IntPtr luaState, int stackPos, string field);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luanet_loadbuffer")]
        internal static extern int LuaNetLoadBuffer(IntPtr luaState, string buff, uint size, string name);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luanet_loadbuffer")]
        internal static extern int LuaNetLoadBuffer(IntPtr luaState, byte[] buff, uint size, string name);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luanet_loadfile")]
        internal static extern int LuaNetLoadFile(IntPtr luaState, string filename);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_error")]
        internal static extern void LuaError(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_checkstack")]
        internal static extern int LuaCheckStack(IntPtr luaState, int extra);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_next")]
        internal static extern int LuaNext(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_pushlightuserdata")]
        internal static extern void LuaPushLightUserData(IntPtr luaState, IntPtr udata);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luaL_checkmetatable")]
        internal static extern int LuaLCheckMetatable(IntPtr luaState, int obj);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_gethookmask")]
        internal static extern int LuaGetHookMask(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_sethook")]
        internal static extern int LuaSetHook(IntPtr luaState, IntPtr func, int mask, int count);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_gethookcount")]
        internal static extern int LuaGetHookCount(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_getinfo")]
        internal static extern int LuaGetInfo(IntPtr luaState, string what, IntPtr ar);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_getstack")]
        internal static extern int LuaGetStack(IntPtr luaState, int level, IntPtr n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_getlocal")]
        internal static extern IntPtr LuaGetLocal(IntPtr luaState, IntPtr ar, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_setlocal")]
        internal static extern IntPtr LuaSetLocal(IntPtr luaState, IntPtr ar, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_getupvalue")]
        internal static extern IntPtr LuaGetUpValue(IntPtr luaState, int funcindex, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "lua_setupvalue")]
        internal static extern IntPtr LuaSetUpValue(IntPtr luaState, int funcindex, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_tonetobject")]
        internal static extern int LuaNetToNetObject(IntPtr luaState, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_newudata")]
        internal static extern void LuaNetNewUData(IntPtr luaState, int val);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_rawnetobj")]
        internal static extern int LuaNetRawNetObj(IntPtr luaState, int obj);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luanet_checkudata")]
        internal static extern int LuaNetCheckUData(IntPtr luaState, int ud, string tname);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_gettag")]
        internal static extern IntPtr LuaNetGetTag();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_pushglobaltable")]
        internal static extern void LuaNetPushGlobalTable(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_popglobaltable")]
        internal static extern void LuaNetPopGlobalTable(IntPtr luaState);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luanet_getglobal")]
        internal static extern void LuaNetGetGlobal(IntPtr luaState, string name);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "luanet_setglobal")]
        internal static extern void LuaNetSetGlobal(IntPtr luaState, string name);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_registryindex")]
        internal static extern int LuaNetRegistryIndex();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl, EntryPoint = "luanet_get_main_state")]
        internal static extern IntPtr LuaNetGetMainState(IntPtr luaState);
    }
#endif

}
