using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{
    public void Boom(){
        GetComponent<AudioSource>().pitch = Random.Range(.8f,1.1f);
        GetComponent<AudioSource>().Play();
        transform.position = new Vector3(1000000,0,0);
        Destroy(this.gameObject,2);
    }
}
