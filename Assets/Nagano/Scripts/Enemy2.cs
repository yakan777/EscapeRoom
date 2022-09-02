using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class Enemy2 : MonoBehaviour
 {
     [Header("攻撃オブジェクト")] public GameObject attackObj;
     [Header("攻撃間隔")] public float interval;
      [Header("重力")] public float gravity;
          [Header("移動速度")] public float speed;
    [Header("画面外でも行動する")] public bool nonVisibleAct;
    [Header("接触判定")] public EnemyCollisionCheck checkCollision;
    public GameObject prefab;

    private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
    private Animator anim = null;
    private ObjectCollision oc = null;
    private CapsuleCollider2D col = null;
    private bool rightTleftF = false;
    private bool isDead = false;
      private float timer;

     // Start is called before the first frame update
     void Start()
     {
                rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        oc = GetComponent<ObjectCollision>();
        col = GetComponent<CapsuleCollider2D>();

          anim = GetComponent<Animator>();
          if (anim == null || attackObj == null)
          {
              Debug.Log("設定が足りません");
              Destroy(this.gameObject);
          }
          else
          {
              attackObj.SetActive(false);
          }
     }

     // Update is called once per frame

          public void Attack()
{
    GameObject g = Instantiate(attackObj);
    g.transform.SetParent(transform);
    g.transform.position = attackObj.transform.position;
    g.transform.rotation = attackObj.transform.rotation;
    g.SetActive(true);
}
     void Update()
     {
          AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);

          //通常の状態
          if (currentState.IsName("boss_stand"))
          {
              if(timer > interval)
              {
                  anim.SetTrigger("shot");
                  timer = 0.0f;
              }
              else
              {
                  timer += Time.deltaTime;
              }
          }
     }
      void FixedUpdate()
    {
        if (!oc.playerStepOn)
        {
            if (sr.isVisible || nonVisibleAct)
            {
                if (checkCollision.isOn)
                {
                    rightTleftF = !rightTleftF;
                }

                int xVector = -1;
                if (rightTleftF)
                {
                    xVector = 1;

                    transform.localScale = new Vector3(-1, 1, 1);
                }
                else
                {

                    transform.localScale = new Vector3(1, 1, 1);

                }
                rb.velocity = new Vector2(xVector * speed, -gravity);
            }
            else
            {
                rb.Sleep();
            }
        }
        else
        {
            if (!isDead)
            {

                anim.Play("dead");
                rb.velocity = new Vector2(0, -gravity);
                isDead = true;
                col.enabled = false;
                Destroy(gameObject, 3f);

                GameObject item=Instantiate(prefab,transform.position+new Vector3(0f,0.1f,0f),Quaternion.identity);
                Rigidbody2D rb2d=item.GetComponent<Rigidbody2D>();
                rb2d.AddForce(new Vector2(-2f,9f),ForceMode2D.Impulse);

            }
            else
            {
                transform.Rotate(new Vector3(0, 0, 5));
            }
        }
    }

 }
