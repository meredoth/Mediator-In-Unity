using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mediator.SOMediator
{
[CreateAssetMenu(fileName = "Mediator", menuName = "Scriptable Objects/Mediator")]
public class MediatorSO : ScriptableObject
{
    private readonly List<IRotateAndChangeColor> _subscribers = new();
    
    public void Subscribe(IRotateAndChangeColor iRotateAndChangeColor) => _subscribers.Add(iRotateAndChangeColor);

    public void UnSubscribe(IRotateAndChangeColor iRotateAndChangeColor) => _subscribers.Remove(iRotateAndChangeColor);

    public void Notify(MonoBehaviour sender, Notification notification)
    {
        foreach (var subscriber in _subscribers)
        {
            switch (notification)
            {
                case Notification.Click: 
                    subscriber.ChangeColor();
                    break;
                case Notification.MouseHover:
                    if (sender is Blue blue && blue.SpriteRenderer.color == Color.blue)
                        return;
                            
                    subscriber.Rotate();
                    break;
                case Notification.ResetColors:
                    subscriber.ResetToDefaultColors();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(notification), notification, null);
            }
        }
    }
}
}
