using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKN_Laser : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.up * speed;
    }
}
