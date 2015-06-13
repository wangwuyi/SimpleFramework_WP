LuaMode = 1;	--0:ulua 1:nlua

if LuaMode == 0 then
	Vector3 = UnityEngine.Vector3;
	GameObject = UnityEngine.GameObject;
else
	import 'System';
	import 'UnityEngine';
	import 'UnityEngine.UI';
	import 'Assembly-CSharp';
end