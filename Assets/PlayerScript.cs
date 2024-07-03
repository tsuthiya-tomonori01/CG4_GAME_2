using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

using Input = UnityEngine.Input;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 2.0f;

        float stageMax = 4.0f;

        float stageMin = -4.0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < stageMax)
            {
                rb.velocity = new Vector3(moveSpeed, 0, 0);

                transform.rotation = Quaternion.Euler(0, 90, 0);

                animator.SetBool("State", true);
            }
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > stageMin)
            {
                rb.velocity = new Vector3(-moveSpeed, 0, 0);

                transform.rotation = Quaternion.Euler(0, -90, 0);

                animator.SetBool("State", true);
            }
        }

        else
        {
            rb.velocity = new Vector3(0, 0, 0);

            Quaternion.Euler(0, 0, 0);

            animator.SetBool("State", false);
        }
    }
}
