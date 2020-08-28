using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float timeToDie;

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject, timeToDie);
    }
}