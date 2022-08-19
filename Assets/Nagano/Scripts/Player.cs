using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float gravity;
    public float jumpSpeed;
    public float jumpHeight;
    public GroundCheck ground;

    private Animator anim=null;
    private Rigidbody2D rb=null;
    private bool isGround=false;
    private bool isJump=false;
    private float jumpPos=0.0f;
    void Start()
    {
        anim=GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
          {
          isGround = ground.IsGround();

          float horizontalKey = Input.GetAxis("Horizontal");
          float xSpeed = 0.0f;
          float ySpeed = -gravity;
          float verticalKey = Input.GetAxis("Jump");

          if (isGround)
          {
              if (verticalKey > 0)
              {
                  ySpeed = jumpSpeed;
                  jumpPos = transform.position.y;
                  isJump = true;
              }
              else
              {
                  isJump = false;
              }
          }
          else if (isJump)
          {
              if (verticalKey > 0 && jumpPos + jumpHeight > transform.position.y)
              {
                  ySpeed = jumpSpeed;
              }
              else
              {
                  isJump = false;
              }
          }
          if (horizontalKey > 0)
          {
              transform.localScale = new Vector3(4, 4, 4);
              anim.SetBool("run", true);
              xSpeed = speed;
          }
          else if (horizontalKey < 0)
          {
              transform.localScale = new Vector3(-4, 4, 4);
              anim.SetBool("run", true);
              xSpeed = -speed;
          }
          else
          {
              anim.SetBool("run", false);
              xSpeed = 0.0f;
          }
          rb.velocity = new Vector2(xSpeed, ySpeed);
      }
 }