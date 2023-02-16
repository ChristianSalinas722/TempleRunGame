using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public void Eat(){
        GetComponent<AudioSource>().pitch = Random.Range(.9f,1.1f);
        GetComponent<AudioSource>().Play();
        transform.position = new Vector3(1000000,0,0);
        Destroy(this.gameObject,2);
    }
}
