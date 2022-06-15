using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKN_ShipController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float turnSpeed = 360;
    [SerializeField] private float moveSpeed = 5;
    
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.up, direction);
        Vector3 targetRotation = new Vector3(0, 0, angle);
        rb2d.MoveRotation(Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime));
        rb2d.MovePosition(rb2d.position + ((Vector2)transform.up * moveSpeed * Time.deltaTime));
    }
}
