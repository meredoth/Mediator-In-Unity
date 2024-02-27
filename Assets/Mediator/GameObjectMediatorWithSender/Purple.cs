using UnityEngine;

namespace Mediator.GameObjectMediatorWithSender
{
public class Purple : MonoBehaviour
{
   [SerializeField] private Mediator mediator;

   private readonly Color defaultColor = Color.magenta;
   
   private SpriteRenderer sr;
        
   private void Awake() => sr = GetComponent<SpriteRenderer>();
   private void OnMouseOver() => mediator.Notify(this, Notification.MouseHover);
   private void OnMouseDown() => mediator.Notify(this, Notification.Click);
   private void OnMouseExit() => mediator.Notify(this, Notification.ResetColors);

   
   public void Rotate()
   {
      transform.Rotate(Vector3.forward, 30f);
      mediator.Notify(this, Notification.Rotate);
   }

   public void ChangeColor() => sr.color = Color.black;

   public void ResetToDefaultColors() => sr.color = defaultColor;
}
}