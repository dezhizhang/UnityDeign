using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    private ISceneState _state;

    private AsyncOperation _ao;
    private bool _isRumStart = false;

    /// <summary>
    /// 设置场景状态
    /// </summary>
    /// <param name="state"></param>
    /// <param name="isLoadScene"></param>是否要加载场景
    public void SetState(ISceneState state, bool isLoadScene = true)
    {
        if (_state != null)
        {
            // 让上一个场景状态做一下清理工作
            _state.StateEnd();
        }

        _state = state;
        // 加载场景
        Debug.Log($"--------加载场景{_state.SceneName}");
        if (isLoadScene)
        {
            _ao = SceneManager.LoadSceneAsync(_state.SceneName);
            // 重新设置是否加载
            _isRumStart = false;
        }
        else
        {
            _state.StateStart();
            _isRumStart = true;
        }
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