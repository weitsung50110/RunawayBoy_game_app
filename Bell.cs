using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigid;
    public GameObject watch_bell;
    GameObject player;
    public AudioSource ring;
    public AudioSource ring2;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        player= GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "bell")
        {
            if (this.transform.position.y >-5f)
            {                
                watch_bell.SetActive(true);
            }
            if(this.transform.position.y<-65)
                watch_bell.SetActive(false);
        }
        if (this.gameObject.name == "bell2")
        {
            if (this.transform.position.y >11f)
            {

                watch_bell.SetActive(true);
            }
            if (this.transform.position.y < -65)
                watch_bell.SetActive(false);
        }
        if (player == true)
        {
            if (player.transform.position.x > -48)
            {
                if (ring.playOnAwake == false)
                {
                    ring.playOnAwake = true;
                }
                if (ring2.playOnAwake == false)
                {
                    ring2.playOnAwake = true;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "ground")
        {
            //print("baba");
            StartCoroutine(Example2());              
            
        }
    }
    
    IEnumerator Example2()
    {
        
        yield return new WaitForSeconds(2f);
        if (this.gameObject.name == "bell")
        {
            this.transform.position = new Vector3(-37.7f, -50.5f, 0);
            rigid.AddForce(new Vector3(0, 30f, 0), ForceMode2D.Impulse);
            
        }
        if (this.gameObject.name == "bell2")
        {
            this.transform.position = new Vector3(-11.9f, -34.5f, 0);
            rigid.AddForce(new Vector3(0, 30f, 0), ForceMode2D.Impulse);
            
        }
    }
}
