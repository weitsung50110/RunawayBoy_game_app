using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer playerSp;
    void Start()
    {
        playerSp = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerSp.flipX == false)
        {
            this.transform.position += new Vector3(0.4f * Time.deltaTime * 60, 0, 0);
        }
        if (playerSp.flipX == true)
        {
            this.transform.position += new Vector3(-0.4f * Time.deltaTime * 60, 0, 0);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "monster"|| other.gameObject.tag == "monster2"|| other.gameObject.tag == "monster3")
        {
            Destroy(this.gameObject);
        }
    }
}
