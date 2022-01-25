using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig_move : MonoBehaviour
{
    // Start is called before the first frame update

    float hp = 0;
    public GameObject playerTransform;
    public float max_hp = 0;
    public GameObject hp_bar;
    private SpriteRenderer pigSp;

    void Start()
    {
        pigSp = this.transform.GetComponent<SpriteRenderer>();
        if (this.gameObject.tag == "monster")
        {
            max_hp = 5;
            hp = max_hp;
        }

        if (this.gameObject.tag == "monster2")
        {
            max_hp = 8;
            hp = max_hp;
        }

        if (this.gameObject.tag == "monster3")
        {
            max_hp = 30;
            hp = max_hp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform==true)
        {
            if (this.transform.position.x > playerTransform.transform.position.x)
            {
                pigSp.flipX = false;
                this.transform.position += new Vector3(-1f * Time.deltaTime, 0, 0);
            
            }
            else
            {
                pigSp.flipX = true;
                this.transform.position += new Vector3(1f * Time.deltaTime, 0, 0);
            }
        }
        if (hp <= 0)
        {
            Destroy(this.gameObject);

        }
        
        float num = (hp / max_hp);
        hp_bar.transform.localScale = new Vector3(num, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            hp -= 1;
        }
    }
}
