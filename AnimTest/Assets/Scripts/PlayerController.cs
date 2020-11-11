using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5.0f;

    Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       //Move Forward
       if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Moving");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("IsStrafe", true);
        }

       if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("IsStrafe", false);
        }

       //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -speed);
            playerAnim.SetBool("IsStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("IsStrafe", false);
        }

        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            playerAnim.SetBool("IsStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("IsStrafe", false);
        }

        //Move Backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
            playerAnim.SetBool("IsStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("IsStrafe", false);
        }

        //Attack Animation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("TrigAttack");
        }
    }  

    //Death Animation
    void OnCollisionEnter2d(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Debug.Log("In Wall");
            playerAnim.SetTrigger("IsDeath");
        }
    }
    
}
