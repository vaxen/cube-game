using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float timeToDie;

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject, timeToDie);
    }
}