using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;
    public float speed = 10.0f;
    private void Awake() //butun life cycleda 1 kere cagirilacak.
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
