using UnityEngine;

namespace Mediator.GameObjectMediatorWithSender
{
public class Green : MonoBehaviour
{
   [SerializeField] private Mediator mediator;
   [SerializeField] private SpriteRenderer[] satelliteRds;
   
   private void OnMouseOver() => mediator.Notify(this, Notification.MouseHover);
   private void OnMouseDown() => mediator.Notify(this, Notification.Click);
   private void OnMouseExit() => mediator.Notify(this, Notification.ResetColors);

   
   public void Rotate()
   {
      transform.Rotate(Vector3.forward, -45f);
      mediator.Notify(this, Notification.Rotate);
   }

   public void ChangeSatellitesColor()
   {
      foreach (var srd in satelliteRds)
      {
         srd.color = Color.black;
      }
   }
   
   public void ResetToDefaultColors()
   {
      foreach (var srd in satelliteRds)
      {
         srd.color = Color.white;
      }
   }
}
}