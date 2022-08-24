using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscript : MonoBehaviour
{

    Animator ani;
    SpriteRenderer sr;
    bool isRight = true;
    // Start is called before the first frame update
    void Start()
    {
        ani = transform.GetChild(0).GetComponent<Animator>();
        sr = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight == true && Input.GetKeyDown(KeyCode.A))
        {
            isRight = false;
            sr.flipX = true;
        }
        else if (isRight == false && Input.GetKeyDown(KeyCode.D))
        {
            isRight = true;
            sr.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger("jump");
        }

        if (transform.position.y < -7)
        {
            transform.position = new Vector3(-7, -1.5f, 0);
        }

        float hori = Input.GetAxis("Horizontal");

        ani.SetFloat("run", Mathf.Abs(hori));
    }
}
