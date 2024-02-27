using UnityEngine;

namespace Mediator.SOMediator
{
public class Red : MonoBehaviour, IRotateAndChangeColor
{
   [SerializeField] private MediatorSO mediator;

   private readonly Color defaultColor = Color.red;
   private SpriteRenderer sr;
        
   private void Awake() => sr = GetComponent<SpriteRenderer>();

   private void OnMouseOver() => mediator.Notify(this, Notification.MouseHover);
   private void OnMouseDown() => mediator.Notify(this, Notification.Click);
   private void OnMouseExit() => mediator.Notify(this, Notification.ResetColors);

   private void OnEnable() => mediator.Subscribe(this);
   private void OnDisable() => mediator.UnSubscribe(this);
   
   public void Rotate() => transform.Rotate(Vector3.forward, -1f);
   public void ChangeColor() => sr.color = Color.black;
   public void ResetToDefaultColors() => sr.color = defaultColor;
}
}