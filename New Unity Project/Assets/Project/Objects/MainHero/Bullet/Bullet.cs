using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float force;
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyMovement>())
        {
            collision.gameObject.GetComponent<EnemyMovement>().GetDamage(damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.name.Contains("SuperWall"))
        {
            Destroy(gameObject);
        }
    }
}
