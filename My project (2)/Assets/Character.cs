using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame

    void Update()
    {
        GetComponent<Transform>().position += new Vector3(1,0,0) * speed * Time.deltaTime;
    }
}
