using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    float x;
    float y;
    Rigidbody2D rb;
    float speed = 5f;
    Animator animator;
    public GameObject panel;
    public bool open;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        panel.SetActive(false);
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        if(x != 0)
        {
            y = 0;
        }

        rb.velocity = new Vector2(x*speed, y*speed);

        
        //アニメージョン
        animator.SetFloat("y.speed",y);
        animator.SetFloat("x.speed",x);

        //インベントリを開く
        if(Input.GetKeyDown(KeyCode.Y))
        {
            panel.SetActive(true);
            open = true;
            Debug.Log("sa");
        }
        if(open == true && Input.GetKeyDown(KeyCode.T))
        {
            panel.SetActive(false);
            open = false;
        }

       
    }
}
