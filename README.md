# DiplimUI
Diplim_ui
Version unity - 2021.3.11f1


[RequireComponent(typeof(ParticleSystem))]
public class DestroyParticle : MonoBehaviour
{
    private ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    [System.Obsolete]
    private void Update()
    {
        if (particleSystem.isStopped)
        {
            Destroy(gameObject);
        }
    }
}
