using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GunData data;
    public Transform firePoint;
    public bool isShooting = false;
    public bool onDelay = false;

    public void Shoot()
    {
        if (isShooting & !onDelay)
        {
            GameObject bullet = Instantiate(data.bullet, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bullet.GetComponent<Bullet>().force, ForceMode2D.Impulse);
            bullet.GetComponent<Bullet>().damage = data.damage;
            onDelay = true;
            Invoke("Reload", data.fire_delay);
        }
    }

    public void Reload()
    {
        onDelay = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isShooting = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            isShooting = false;
        }
        Shoot();
    }
}
