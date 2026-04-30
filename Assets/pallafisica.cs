using UnityEngine;

public class pallafisica : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;

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
        float intensity = 10f;

        rb.AddForce(direction * intensity, ForceMode.Impulse);

    }

    private void Start()
    {
        // Dopo 10 secondi chiama la funzione
        Invoke(nameof(LanciaVersoPlayer), 5f);
    }

    private void Update()
    {
        //        float step = speed * Time.deltaTime;
        //        GetComponent<Transform>().Translate(CalcolaDirezionePlayer() * step);
    }
}
