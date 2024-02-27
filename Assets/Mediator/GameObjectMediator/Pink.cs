using UnityEngine;

namespace Mediator.Mediator.GameObjectMediator
{
public class Pink : MonoBehaviour
{
   [SerializeField] private Mediator mediator;

   private readonly Color defaultColor = new (1f, 0.753f, 0.796f);
   private SpriteRenderer sr;
        
   private void Awake() => sr = GetComponent<SpriteRenderer>();
   
   private void OnMouseOver() => mediator.Notify(Notification.MouseHover);
   private void OnMouseDown() => mediator.Notify(Notification.Click);
   private void OnMouseExit() => mediator.Notify(Notification.ResetColors);

   
   public void Rotate()
   {
      transform.Rotate(Vector3.forward, -30f);
      mediator.Notify(Notification.Rotate);
   }

   public void ChangeColor() => sr.color = Color.black;
   
   public void ResetToDefaultColors() => sr.color = defaultColor;
}
}