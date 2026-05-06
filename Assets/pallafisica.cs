using UnityEngine;

public class pallafisica : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    [SerializeField, Range(1,10)] float timerStart = 5f;
    Vector3 CalcolaDirezionePlayer()
    {
        Vector3 miaPosizone = GetComponent<Transform>().position;
        Vector3 poszionePlayer = player.GetComponent<Transform>().position;
        return (poszionePlayer - miaPosizone).normalized;
    }

    public void LanciaVersoPlayer()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 poszionePlayer = player.GetComponent<Transform>().position;
        Vector3 direction = CalcolaDirezionePlayer();

        rb.AddForce(direction * speed, ForceMode.Impulse);

    }

    private void Start()
    {
        Invoke(nameof(LanciaVersoPlayer), timerStart);
    }
}
