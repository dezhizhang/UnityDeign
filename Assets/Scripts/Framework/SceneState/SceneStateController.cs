using UnityEngine;

public class SceneStateController
{
    private ISceneState _state;

    public void StateUpdate()
    {
        if (_state != null)
        {
            _state.StateUpdate();
        }
    }
}