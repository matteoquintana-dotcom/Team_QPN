using UnityEngine;
using UnityEngine.InputSystem;

public class ZanonInputManager : MonoBehaviour
{
    public InputActionReference touchPositionReference;

    public void OnTouchPress(InputValue inputValue)
    {
        Debug.Log("L'utente ha premuto lo schermo");
        Vector2 touchPosition = touchPositionReference.action.ReadValue<Vector2>();
        Debug.Log("In posizione: " + touchPosition);


        Ray ray = Camera.main.ScreenPointToRay(touchPosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            string hitGameobjectName = hit.collider.gameObject.name;
            if(hitGameobjectName == "palla")
            {
                Rigidbody pallaRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                Vector3 direzione = ray.direction;
                direzione.y = 0.5f;
                direzione = direzione.normalized;
                float potenzaColpo = 10f;
                pallaRB.AddForce(direzione * potenzaColpo, ForceMode.Impulse);
            }
        }
    }
}
