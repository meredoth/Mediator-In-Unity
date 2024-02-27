using UnityEngine;

namespace Mediator.SOMediator
{
public class Blue : MonoBehaviour, IRotateAndChangeColor
{
   [SerializeField] private MediatorSO mediator;

   private readonly Color defaultColor = Color.blue;

   public SpriteRenderer SpriteRenderer { get; private set; }

   private void Awake() => SpriteRenderer = GetComponent<SpriteRenderer>();

   private void OnMouseOver() => mediator.Notify(this, Notification.MouseHover);
   private void OnMouseDown() => mediator.Notify(this, Notification.Click);
   private void OnMouseExit() => mediator.Notify(this, Notification.ResetColors);

   private void OnEnable() => mediator.Subscribe(this);

   private void OnDisable() => mediator.UnSubscribe(this);

   public void Rotate() => transform.Rotate(Vector3.forward, 1f);
   public void ChangeColor() => SpriteRenderer.color = Color.black;
   public void ResetToDefaultColors() => SpriteRenderer.color = defaultColor;
}
}