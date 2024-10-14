using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //Action은 무조건 void 만 반환해야 한다 아니면 Func?
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    { 
        OnMoveEvent?.Invoke(direction);
    }
    public void CallLookEvent(Vector2 direction)
    { 
        OnLookEvent?.Invoke(direction);
    }
}
