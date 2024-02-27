using System;
using UnityEngine;

namespace Mediator.Mediator.GameObjectMediator
{

public enum Notification
{
   Click,
   MouseHover,
   Rotate,
   ResetColors
}

public class Mediator : MonoBehaviour
{
   [SerializeField] private Red red;
   [SerializeField] private Green green;
   [SerializeField] private Blue blue;
   [SerializeField] private Yellow yellow;
   [SerializeField] private Purple purple;
   [SerializeField] private Pink pink;
   
   public void Notify(Notification notification)
   {
      switch (notification)
      {
         case Notification.Click:
            purple.ChangeColor();
            pink.Rotate();
            break;
         case Notification.MouseHover:
            blue.ChangeColor();
            green.Rotate();
            break;
         case Notification.Rotate:
            red.ChangeColor();
            yellow.ChangeSatellitesColor();
            break;
         case Notification.ResetColors:
            red.ResetToDefaultColors();
            green.ResetToDefaultColors();
            blue.ResetToDefaultColors();
            yellow.ResetToDefaultColors();
            purple.ResetToDefaultColors();
            pink.ResetToDefaultColors();
            break;
         default:
            throw new ArgumentOutOfRangeException(nameof(notification), notification, null);
      }
   }
}
}
