using UnityEngine;
using UnityEngine.UI;

public class StartState : ISceneState
{
    // 图片的logo
    private Image _logo;


    private float _smoothingSpeed = 1.0f;


    public StartState(SceneStateController controller) : base("01StartScene", controller)
    {
    }

    public override void StateStart()
    {
        _logo = GameObject.Find("Logo").GetComponent<Image>();
    }

    public override void StateUpdate()
    {
        _logo.color = Color.Lerp(_logo.color, Color.white, _smoothingSpeed * Time.deltaTime);
    }
}