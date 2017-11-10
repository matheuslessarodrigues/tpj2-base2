using UnityEngine;

public sealed class Bullet : MonoBehaviour
{
    public Rigidbody2D bulletRigidbody;

    public Vector2 impulse;

    private void Start()
    {
        bulletRigidbody.AddForce(impulse, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Camera.main.GetComponent<CameraShake>().Shake();
        Destroy(gameObject);
    }
}
