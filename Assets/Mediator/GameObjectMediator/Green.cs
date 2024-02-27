using UnityEngine;

namespace Mediator.Mediator.GameObjectMediator
{
public class Green : MonoBehaviour
{
   [SerializeField] private Mediator mediator;
   [SerializeField] private SpriteRenderer[] satelliteRds;
   
   private void OnMouseOver() => mediator.Notify(Notification.MouseHover);
   private void OnMouseDown() => mediator.Notify(Notification.Click);
   private void OnMouseExit() => mediator.Notify(Notification.ResetColors);

   
   public void Rotate()
   {
      transform.Rotate(Vector3.forward, -45f);
      mediator.Notify(Notification.Rotate);
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