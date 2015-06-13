require "luaclass"
require "define"
require "functions"

--管理器--
local game;	
local this;
GameManager = {};

function GameManager.LuaScriptPanel()
    this = GameManager;
	return 'Prompt', 'Message';
end

function GameManager.Awake()
    --warn('Awake--->>>');
end

--启动事件--
function GameManager.Start()
	--warn('Start--->>>');
end

--初始化完成，发送链接服务器信息--
function GameManager.OnInitOK()
	warn('OnInitOK--->>>');
	createPanel("Prompt");

    --测试lua类--
    luaclass:New(10, 20):test();
end

--销毁--
function GameManager.OnDestroy()
	--warn('OnDestroy--->>>');
end
