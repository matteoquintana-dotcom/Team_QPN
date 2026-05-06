using UnityEngine;

public class BallSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}