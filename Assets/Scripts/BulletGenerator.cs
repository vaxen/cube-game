#pragma warning disable 649
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    [SerializeField] private Transform bulletGenerator;

    [SerializeField] private GameObject bullet;

    [SerializeField] private float bulletSpeed;

    private Vector2 lookDirection;
    private Vector2 mousePos;

    private float lookAngle;

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ////
        lookDirection = mousePos;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        GameObject firedBullet = Instantiate(bullet, bulletGenerator.position, bulletGenerator.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = bulletGenerator.up * bulletSpeed;
    }
}