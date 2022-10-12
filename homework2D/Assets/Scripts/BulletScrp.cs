using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScrp : MonoBehaviour
{
    [SerializeField] float speed=10f;
    [SerializeField] GameObject bulletPos;
    [SerializeField] GameObject Player;
    Rigidbody2D rb;
    float Horizontal;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        //transform.position += new Vector3(Player.transform.localPosition.x * speed, 0, 0) * Time.deltaTime;
        //transform.position+=Vector3.r*speed*Time.deltaTime;
        

        ////float x = Input.GetAxis("Horizontal");
        //if (x>0)
        //{
        //    rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);

        //}
        //else if (x < 0)
        //{
        //    rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);

        //}

    }
}
