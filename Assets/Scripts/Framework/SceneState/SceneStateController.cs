using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    private ISceneState _state;

    private AsyncOperation _ao;
    private bool _isRumStart = false;

    public void SetState(ISceneState state)
    {
        if (_state != null)
        {
            // 让上一个场景状态做一下清理工作
            _state.StateEnd();
        }

        _state = state;
        // 加载场景
        Debug.Log($"--------加载场景{_state.SceneName}");
        _ao = SceneManager.LoadSceneAsync(_state.SceneName);
        // 重新设置是否加载
        _isRumStart = false;
    }

    public void StateUpdate()
    {
        Debug.Log($"-------StateUpdate更新状态");
        // 如果没有加载完直接跳出
        if (_ao != null && !_ao.isDone) return;

        if (_ao != null && _ao.isDone && !_isRumStart)
        {
            _state.StateUpdate();
            _isRumStart = true;
        }
    }
}