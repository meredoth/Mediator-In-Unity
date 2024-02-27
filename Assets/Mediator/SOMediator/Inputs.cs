using UnityEngine;
using UnityEngine.InputSystem;

namespace Mediator.SOMediator
{
public class Inputs : MonoBehaviour
{
    [SerializeField] private GameObject bluePrefab;

    private GameObject _go;
    
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (_go == null)
            {
                _go = Instantiate(bluePrefab,Vector3.zero, Quaternion.identity);
            }
            else
            {
                Destroy(_go);
                _go = null;
            }
        }
    }
}
}
