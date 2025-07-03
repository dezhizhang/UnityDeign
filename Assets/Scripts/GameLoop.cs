using UnityEngine;


public class GameLoop : MonoBehaviour
{
    private SceneStateController _controller;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        Debug.Log("----GameLoop Start");
        _controller = new SceneStateController();
        // 设置默认状态
        _controller.SetState(new StartState(_controller),false);
    }

    private void Update()
    {
        _controller.StateUpdate();
    }
}
