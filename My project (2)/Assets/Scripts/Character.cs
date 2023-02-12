using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 5f;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame

    void Update()
    {
       // transform.position += new Vector3( Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0) * speed * Time.deltaTime;
       GetComponent<Rigidbody2D>().MovePosition(transform.position + (new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"),0)) * Time.fixedDeltaTime * speed);

    }
}
 