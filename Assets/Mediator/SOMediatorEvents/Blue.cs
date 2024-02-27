using UnityEngine;

namespace Mediator.SOMediatorEvents
{
public class Blue : MonoBehaviour
{
   [SerializeField] private MediatorEventsSO mediator;

   private readonly Color defaultColor = Color.blue;

   public SpriteRenderer SpriteRenderer { get; private set; }

   private void Awake() => SpriteRenderer = GetComponent<SpriteRenderer>();

   private void OnMouseOver() => mediator.OnMouseHover(this);
   private void OnMouseDown() => mediator.OnClicked(this);
   private void OnMouseExit() => mediator.OnMouseExited(this);

   private void OnEnable()
   {
      mediator.Clicked += ChangeColor;
      mediator.MouseHover += Rotate;
      mediator.MouseExited += ResetToDefaultColors;
   }

   private void OnDisable()
   {
      mediator.Clicked -= ChangeColor;
      mediator.MouseHover -= Rotate;
      mediator.MouseExited -= ResetToDefaultColors;
   }

   private void Rotate(MonoBehaviour monoBehaviour) => transform.Rotate(Vector3.forward, 1f);
   private void ChangeColor(MonoBehaviour monoBehaviour) => SpriteRenderer.color = Color.black;
   private void ResetToDefaultColors(MonoBehaviour monoBehaviour) => SpriteRenderer.color = defaultColor;
}
}