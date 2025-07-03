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
        _controller = new SceneStateController();
    }

    private void Update()
    {
        _controller.StateUpdate();
    }
}

// public class Context
// {
//     private IState _state;
//
//     public void SetState(IState state)
//     {
//         this._state = state;
//     }
//
//     public void Handle(int arg)
//     {
//         _state.Handle(arg);
//     }
// }
//
// public interface IState
// {
//     void Handle(int arg);
// }
//
// public class ConcreteStateA : IState
// {
//     private Context _context;
//
//     public ConcreteStateA(Context context)
//     {
//         this._context = context;
//     }
//
//     public void Handle(int arg)
//     {
//         Debug.Log("ConcreteStateA");
//         if (arg > 10)
//         {
//             _context.SetState(new ConcreteStateB(_context));
//         }
//     }
// }
//
// public class ConcreteStateB : IState
// {
//     private Context _context;
//
//     public ConcreteStateB(Context context)
//     {
//         this._context = context;
//     }
//
//     public void Handle(int arg)
//     {
//         Debug.Log("ConcreteStateB");
//         if (arg <= 10)
//         {
//             _context.SetState(new ConcreteStateA(_context));
//         }
//     }
// }