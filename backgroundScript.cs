using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{
    Vector3 kero = new Vector3(1, 1, 1);
    private float speed = 3.5f;
    Rigidbody2D e_rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        float aa = Random.Range(0.045f, 0.08f);
        Vector3 kero = new Vector3(aa,aa, 1);
        
        e_rigidbody2D = GetComponent<Rigidbody2D>();
        speed = Random.Range(1.0f, 2.0f);
        if(gameObject.tag == "star")
        {
            transform.localScale = kero;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = transform.position;
        if (Position.y < -6.0)
        {
            Destroy(gameObject);
        }
        e_rigidbody2D.velocity = new Vector2(e_rigidbody2D.velocity.x, -speed);
    }
}
