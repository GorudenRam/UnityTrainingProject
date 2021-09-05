using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public EnemyData data;

    public Rigidbody2D rb;
    public Rigidbody2D heroRb;

    float hp;

    Vector2 movement;
    Vector2 heroPos;

    private void Start()
    {
        Invoke("SetValues", 0.1f);
    }

    void Update()
    {
        if (!heroRb) return;
        heroPos = heroRb.position;
        movement = (heroPos - rb.position).normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * data.speed * Time.fixedDeltaTime);

        Vector2 lookDir = heroPos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
    public void ChangeToGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void GetDamage(float damage) 
    {
        hp -= damage;
        if (hp <= 0)
        { 
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Movement>())
        {
            Destroy(collision.gameObject);
            Invoke("ChangeToGame", 1.5f);
        }
    }

    private void SetValues()
    {
        hp = data.HeatPoints;
        gameObject.GetComponent<SpriteRenderer>().sprite = data.sprite;
    }
}
