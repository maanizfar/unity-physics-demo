using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private Collider _marble;
    [SerializeField] private ParticleSystem _particles;


    private void OnTriggerEnter(Collider other)
    {
        if (other == _marble)
        {
            _particles.Play();
        }
    }
}
