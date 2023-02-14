using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    Rigidbody2D goldRd;
    public float gravity;
    public void ChangeGravity(){
        goldRd.AddForce(Vector2.down * gravity * goldRd.mass);
    }
}
