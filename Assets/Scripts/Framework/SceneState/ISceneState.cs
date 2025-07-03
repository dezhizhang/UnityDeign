public class ISceneState
{
    // 场景名称
    private string _sceneName;

    // 状态的拥有者
    private SceneStateController _controller;

    public ISceneState(string sceneName,SceneStateController controller)
    {
        _sceneName = sceneName;
        _controller = controller;
    }

    public virtual void StateStart()
    {
    }

    public virtual void StateEnd()
    {
    }

    public virtual void StateUpdate()
    {
    }
}