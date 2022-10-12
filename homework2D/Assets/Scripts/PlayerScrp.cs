using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrp : MonoBehaviour
{
    float x;
    float speed = 10f;
    float currentPos=0f;
    float newPos;
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform BulletPos;
    void Start()
    {
        
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x*speed, 0, 0)*Time.deltaTime;
        Debug.Log(x);
        newPos = transform.position.x;
        if (newPos<currentPos)
        {
            currentPos = newPos;
            transform.localRotation=Quaternion.Euler(0,180,0);
        }
        else if(newPos>currentPos)
        {
            currentPos = newPos;
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5f);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, BulletPos.position,transform.rotation);
        }
    }
}
