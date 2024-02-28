using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    public GameObject particle;
    public float followSpeed;
    public void ParticleFollow(Touch touch, Camera mainCamera, bool activate)
    {
        particle.SetActive(activate);
        Vector2 normalizedTouch = mainCamera.ScreenToWorldPoint(touch.position);
        particle.transform.position = normalizedTouch;
    }
}