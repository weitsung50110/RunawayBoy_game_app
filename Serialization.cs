using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class Serialization : MonoBehaviour
{
    // Start is called before the first frame update
    public int ww =0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        /*if(Input.GetKeyDown(KeyCode.W))
        {
            FileStream fs = new FileStream(Application.dataPath + "/save123.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("你好");
            sw.WriteLine("20");
            sw.Close();
            fs.Close();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream fs = File.Open(Application.dataPath + "/yahoo123.sexy", FileMode.Create);
            bf.Serialize(fs, "你好20");
            fs.Close();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            FileStream fs = new FileStream(Application.dataPath + "/save123.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            ww = int.Parse(sr.ReadLine());
            sr.Close();
            fs.Close();
        }
        */
    }
    

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player"&&this.gameObject.name=="coin")
        {
            ww = ww + 1;
            FileStream fs = new FileStream(Application.persistentDataPath + "/save1.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(ww);
            sw.Close();
            fs.Close();
        }
        if (other.gameObject.tag == "Player" && this.gameObject.name == "coin2")
        {
            ww = ww + 2;
            FileStream fs = new FileStream(Application.persistentDataPath + "/save1.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(ww);
            sw.Close();
            fs.Close();
        }
        if (other.gameObject.tag == "Player" && this.gameObject.name == "coin3")
        {
            ww = ww + 3;
            FileStream fs = new FileStream(Application.persistentDataPath + "/save1.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(ww);
            sw.Close();
            fs.Close();
        }
    }

    /*public void LoadData()
    {
        FileStream fs = new FileStream(Application.dataPath + "/save123.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        ww = int.Parse(sr.ReadLine());
        sr.Close();
        fs.Close();
        if(ww!=2)
        {
            button1.transform.localPosition = new Vector3(-1006, -33, 0);
        }
    }*/
}
