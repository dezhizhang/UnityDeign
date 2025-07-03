public class ISceneState
{
    // 场景名称
    private string _sceneName;

    public string SceneName
    {
        get { return _sceneName; }
    }

    // 状态的拥有者
    private SceneStateController _controller;

    public ISceneState(string sceneName, SceneStateController controller)
    {
        _sceneName = sceneName;
        _controller = controller;
    }

    // 每次进入到这个状态时候调用
    public virtual void StateStart()
    {
    }

    public virtual void StateEnd()
    {
    }
    // 每次离开这个状态时都会调用
    public virtual void StateUpdate()
    {
    }
}