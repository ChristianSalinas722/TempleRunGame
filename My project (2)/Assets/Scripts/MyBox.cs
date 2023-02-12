using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBox : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeColor(Color c){
        GetComponent<SpriteRenderer>().color = c;
    }
}
