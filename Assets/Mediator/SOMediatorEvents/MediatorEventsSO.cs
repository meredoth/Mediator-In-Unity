using System;
using UnityEngine;

namespace Mediator.SOMediatorEvents
{
[CreateAssetMenu(fileName = "MediatorEventsSO", menuName = "Scriptable Objects/MediatorEventsSO")]
public class MediatorEventsSO : ScriptableObject
{
    public event Action<MonoBehaviour> Clicked;
    public event Action<MonoBehaviour> MouseHover;
    public event Action<MonoBehaviour> MouseExited;

    public void OnClicked(MonoBehaviour monoBehaviour) => Clicked?.Invoke(monoBehaviour);

    public void OnMouseHover(MonoBehaviour monoBehaviour)
    {
        if (monoBehaviour is Blue blue && blue.SpriteRenderer.color == Color.blue)
            return;
        
        MouseHover?.Invoke(monoBehaviour);
    }

    public void OnMouseExited(MonoBehaviour monoBehaviour) => MouseExited?.Invoke(monoBehaviour);
}
}
