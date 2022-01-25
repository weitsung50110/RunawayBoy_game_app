using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class player_move : MonoBehaviour
{

    GameObject cameraObj;
    Vector3 camera2player;
    Vector3 sky2player;

    public Joystick Joystick;
    public joybutton joybutton;
    public joybutton joybutton2;
    public Rigidbody2D rigid;
    public SpriteRenderer playerSp;
    public SpriteRenderer bulletSp;
    public GameObject bullet;

    public Image dead_word;
    public Image hp_bar;
    public Image woman;
    public Animator playerAni;

    GameObject player;
    GameObject sky1;

    bool jump;
    bool run;
    bool shoot;

    float hp = 0;
    public float max_hp = 0;
    void Start()
    {
        player = GameObject.Find("player");
        cameraObj = GameObject.Find("cam");
        sky1= GameObject.Find("sky1");

        sky2player= sky1.transform.position- player.transform.position;
        camera2player = cameraObj.transform.position - player.transform.position;
        shoot = false;

        max_hp = 5;
        hp = max_hp;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Contorl();
    }
    void Update()
    {
        CameraFollow();
        
        Hp_control();
        SkyFollow();
    }
    void Hp_control()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
            dead_word.transform.localPosition=new Vector3(6, 18, 0);
        }
        float num = (hp / max_hp);
        hp_bar.transform.localScale = new Vector3(num, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            jump = false;
            print("Hit the ground");
        }

        if (other.gameObject.tag == "monster"|| other.gameObject.tag == "monster2"|| 
            other.gameObject.tag == "monster3" || other.gameObject.tag == "bell")
        {
            hp = hp- 1;
            playerAni.SetTrigger("hurt");
            if (playerSp.flipX == true)
            {
                rigid.AddForce(new Vector3(2f, 2f, 0), ForceMode2D.Impulse);
            }

            if (playerSp.flipX == false)
            {
                rigid.AddForce(new Vector3(-2f, 2f, 0), ForceMode2D.Impulse);
            }
        }

        if (other.gameObject.tag == "coin")
        {
            print("You Win");
            Destroy(other.gameObject);
            woman.transform.localPosition = new Vector3(6, 7, 0);
        }

        if (other.gameObject.tag == "water")
        {
            hp = hp - 10;
        }
    }
    void Contorl()
    {
        run = false;
        if (Joystick.Horizontal >= .0001f)
        {
            run = true;
            this.transform.position += new Vector3(0.13f , 0, 0);
            if (run)
            {
                playerAni.SetInteger("status", 1);
                //player.GetComponent<Animator>().Play("Run - Bat");
                if (playerSp.flipX == true)
                {
                    playerSp.flipX = false;
                }
                
                if (bulletSp.flipX == true)
                {
                    bulletSp.flipX = false;
                }
            }
            
        }

        if (Joystick.Horizontal <= -.0001f)
        {
            run = true;
            this.transform.position += new Vector3(-0.13f , 0, 0);
            
            if (run)
            {
                playerAni.SetInteger("status", 1);
                if (playerSp.flipX==false)
                {
                    playerSp.flipX = true;
                }
            }

            if (bulletSp.flipX == false)
            {
                bulletSp.flipX = true;
            }
        }
        if (!run)
        {
            if (playerAni.GetInteger("status") == 1 )
            {
                playerAni.SetInteger("status", 0);
            }
            if (playerAni.GetInteger("status") == 2)
            {
                playerAni.SetInteger("status", 0);
            }
            
        }
        
        if (!jump && joybutton.pressed)
        {
            jump = true;
            rigid.AddForce(new Vector3(0, 8.4f , 0), ForceMode2D.Impulse);
            playerAni.SetInteger("status", 2);
            
        }

        if (!shoot && joybutton2.pressed)
        {
            shoot = true;
            playerAni.SetTrigger("attack");
            GameObject star = Instantiate(bullet); //複製場景上一個叫做ball的物件
            star.transform.position = player.transform.position;
            StartCoroutine(Example());
            Destroy(star, 1.5f);
        }
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(0.4f);
        shoot = false;
    }
    void CameraFollow()
    {
        cameraObj.transform.position = player.transform.position + camera2player;
    }

    void SkyFollow()
    {
        sky1.transform.position = player.transform.position + sky2player;
    }

}
