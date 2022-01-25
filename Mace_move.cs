using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace_move : MonoBehaviour
{
    // Start is called before the first frame update
    float hp = 0;
    public float max_hp = 0;
    public GameObject hp_bar;
    void Start()
    {
        max_hp = 5;
        hp = max_hp;
    }

    // Update is called once per frame
    void Update()
    {
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
