using UnityEngine;
using UnityEngine.InputSystem;

public class ZanonInputManager : MonoBehaviour
{
    public InputActionReference touchPositionReference;
    [SerializeField, Range(0.1f, 10)] private float forzaPalla = 1;
    public void OnTouchPress(InputValue inputValue)
    {
        Debug.Log("L'utente ha premuto lo schermo");
        Vector2 touchPosition = touchPositionReference.action.ReadValue<Vector2>();
        Debug.Log("In posizione: " + touchPosition);


        Ray ray = Camera.main.ScreenPointToRay(touchPosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.CompareTag("Palla"))
            {
                Rigidbody pallaRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                Vector3 direzione = ray.direction;
                direzione.y = 0.5f;
                direzione = direzione.normalized;
                pallaRB.AddForce(direzione * forzaPalla, ForceMode.Impulse);
            }
        }
    }
}
