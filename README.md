# DiplimUI
Diplim_ui


http://unity3d.ru/distribution/viewtopic.php?f=18&p=317770

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/HOWTO-UIMultiResolution.html


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
