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
        GetComponent<Transform>().position += new Vector3( Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0) * speed * Time.deltaTime;
       

    }
}
 