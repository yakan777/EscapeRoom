using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [Header("攻撃オブジェクト")] public GameObject attackObj;
    [Header("攻撃の出る位置")]public Transform bulletPos;
    [Header("攻撃間隔")] public float interval;
    [Header("重力")] public float gravity;
    [Header("移動速度")] public float speed;
    [Header("画面外でも行動する")] public bool nonVisibleAct;
    [Header("接触判定")] public EnemyCollisionCheck checkCollision;
    [Header("やられた時に鳴らすSE")] public AudioClip bossDeadSE;
    [Header("ショットSE")] public AudioClip shotSE;
    public GameObject prefab;
    public GameObject target;
    public float bossDistance;

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
        //StartCoroutine(loop());

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
    /*private IEnumerator loop() {
        // ループ
        while (true) {
            // 1秒毎にループします
            yield return new WaitForSeconds(1.5f);
            onTimer();
        }
    }
    private void onTimer() {
        // 1秒毎に呼ばれます
       GManager.instance.PlaySE(shotSE);
    }*/
    public void Attack()
    {
        Debug.Log("打った");
        GameObject g = Instantiate(attackObj);
        // g.transform.SetParent(transform);
        g.transform.position = attackObj.transform.position;
        g.transform.rotation = attackObj.transform.rotation;
        g.SetActive(true);
    }
    void Update()
    {

        AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);
        /*Vector2 UnityChan = target.transform.position;
        float dis = Vector2.Distance(UnityChan, this.transform.position);
        if (dis < bossDistance)
        {
            loop();
        }
        IEnumerator loop()
        {
            // ループ
            while (true)
            {
                // 1秒毎にループします
                yield return new WaitForSeconds(1.5f);
                onTimer();
            }
        }
        void onTimer()
        {
            // 1秒毎に呼ばれます
            if (GManager.instance != null)
            {
                GManager.instance.PlaySE(shotSE);
            }
        }*/



        //通常の状態
        if (currentState.IsName("boss_stand"))
        {
            if (timer > interval)
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
                if (checkCollision != null && checkCollision.isOn)
                {
                    rightTleftF = !rightTleftF;
                }

                int xVector = -1;
                if (rightTleftF)
                {
                    xVector = 1;

   //                 transform.localScale = new Vector3(-1.5f, 1.5f, 1);
                }
                else
                {

//                    transform.localScale = new Vector3(1.5, 1.5, 1);

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
                //弾の消す処理
                for(int i=0;i<this.transform.childCount;i++){
                    Destroy(this.transform.GetChild(i).gameObject);
                }

                anim.Play("dead");
                rb.velocity = new Vector2(0, -gravity);
                isDead = true;
                col.enabled = false;
                if (GManager.instance != null)
                {
                    GManager.instance.PlaySE(bossDeadSE);
                }
                Destroy(gameObject, 1.5f);

                GameObject item = Instantiate(prefab, transform.position + new Vector3(0f, 0.1f, 0f), Quaternion.identity);
                Rigidbody2D rb2d = item.GetComponent<Rigidbody2D>();
                rb2d.AddForce(new Vector2(-2f, 9f), ForceMode2D.Impulse);

            }
            else
            {
                transform.Rotate(new Vector3(0, 0, -2.5f));
            }
        }
    }

    /*IEnumerator loop()
    {
        // ループ
        while (true)
        {
                  Vector2 UnityChan = target.transform.position;
        float dis = Vector2.Distance(UnityChan, this.transform.position);
        if (dis < bossDistance)
        {
            yield return new WaitForSeconds(1.5f);
            Debug.Log("ok");
            onTimer();
        }
        }
    }
    void onTimer()
    {
        // 1秒毎に呼ばれます
        if (GManager.instance != null)
        {
            GManager.instance.PlaySE(shotSE);
        }
    }*/

}
