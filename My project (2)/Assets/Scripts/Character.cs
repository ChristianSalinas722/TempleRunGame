using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 5f;
    public SpriteRenderer sr;
     Rigidbody2D rb2d;
     public Shots shots;

     public Points golds;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //shots = GameObject.Find("Projectile").GetComponent<Shots>();
        shots = GameObject.FindGameObjectWithTag("PewPew").GetComponent<Shots>();
        golds = GameObject.FindGameObjectWithTag("Gold").GetComponent<Points>();
    }

    // Update is called once per frame

    void Update()
    {
       // transform.position += new Vector3( Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0) * speed * Time.deltaTime;
       
    }
    void FixedUpdate(){
         rb2d.MovePosition(transform.position + (new Vector3(Input.GetAxisRaw("Horizontal"),0,0)) * Time.fixedDeltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "PewPew"){
            shots = other.GetComponent<Shots>();
        }
        if(other.tag == "Gold"){
            Destroy(other.gameObject); 
            golds.ChangeGravity();
            
        }

        Destroy(other.gameObject);
    }
}
 