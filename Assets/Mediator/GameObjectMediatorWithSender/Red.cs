using UnityEngine;

namespace Mediator.GameObjectMediatorWithSender
{
public class Red : MonoBehaviour
{
   [SerializeField] private Mediator mediator;
   [SerializeField] private SpriteRenderer[] satelliteRds;

   private readonly Color defaultColor = Color.red;
   private SpriteRenderer sr;
        
   private void Awake() => sr = GetComponent<SpriteRenderer>();

   private void OnMouseOver() => mediator.Notify(this, Notification.MouseHover);
   private void OnMouseDown() => mediator.Notify(this, Notification.Click);

   private void OnMouseExit() => mediator.Notify(this, Notification.ResetColors);

   public void ChangeColor() => sr.color = Color.black;
        
   public void ChangeSatellitesColor()
   {
      foreach (var srd in satelliteRds)
      {
         srd.color = Color.black;
      }
   }
        
   public void ResetToDefaultColors()
   {
      sr.color = defaultColor;
      foreach (var srd in satelliteRds)
      {
         srd.color = Color.white;
      }
   }
}
}