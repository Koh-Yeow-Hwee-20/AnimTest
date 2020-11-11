using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5.0f;

    Animator playerAnim;
    Animator playerAttack;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();

        playerAttack = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("IsStrafe", true);
        }

       if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("IsStrafe", false);
        }
     /*
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
            playerAnim.SetBool("IsStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("IsStrafe", false);
        }
     */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAttack.SetTrigger("TrigAttack");
        }
    }
}
