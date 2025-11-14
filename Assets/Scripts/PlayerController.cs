using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed = 5f; // Oyuncunun yatay hareket hizi

    private Rigidbody2D rb; // Player objesinin Rigidbody2D bilesenini tutacak degisken

    private float horizontalInput; // Yatay eksen inputunu tutacak degisken

    public float jumpForce = 7f; // Ziplama kuvveti
    public Transform check_Bottom; // Alt sensor
    public Transform check_Top;    // Ust sensor
    public Transform check_Left;   // Sol sensor
    public Transform check_Right;  // Sag sensor
    public float checkRadius = 0.2f; // Tum sensorler icin ortak tarama yaricapi
    public LayerMask groundLayer;    // Zemin katmani
    private bool isTouchingSurface; // Herhangi bir yuzey 'Ground'a degiyor mu?

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D bilesenini al ve rb degiskenine ata
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");// Yatay eksen inputunu al
        bool bottomCheck = Physics2D.OverlapCircle(check_Bottom.position, checkRadius, groundLayer); // Alt sensor ile zemin kontrolu
        bool topCheck = Physics2D.OverlapCircle(check_Top.position, checkRadius, groundLayer); // Ust sensor ile zemin kontrolu
        bool leftCheck = Physics2D.OverlapCircle(check_Left.position, checkRadius, groundLayer); // Sol sensor ile zemin kontrolu
        bool rightCheck = Physics2D.OverlapCircle(check_Right.position, checkRadius, groundLayer); // Sag sensor ile zemin kontrolu

        isTouchingSurface = bottomCheck || topCheck || leftCheck || rightCheck; // Herhangi bir sensor zeminle temas ediyorsa true yap
        if (Input.GetButtonDown("Jump") && isTouchingSurface)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);// Ziplama islemi
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);// Rigidbody2D'nin yatay hizini inputa ve moveSpeed'e gore ayarla, dikey hizini koru
    }
}
