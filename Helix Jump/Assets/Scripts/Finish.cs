using UnityEngine;

public class Finish : MonoBehaviour
{
    public ParticleSystem fireworksParticle;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;
        player.ReachFinish();
        fireworksParticle.Play();
    }
}
