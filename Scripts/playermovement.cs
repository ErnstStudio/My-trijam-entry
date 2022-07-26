using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour

{

    public float moveSpeed = 5f;
    //public Animator animator;

    public float currentspeed;

    public Rigidbody2D rb;

    public Camera cam;



    Vector2 movement;

    Vector2 mousePos;



    // Update is called once per frame

    void Update()

    {

        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");

        // animator.SetFloat("Speed", Mathf.Abs(moveSpeed));

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }



    private void FixedUpdate()

    {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);



        Vector2 lookDir = mousePos - rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    /*if (collision.collider.CompareTag("Server"))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    */
}