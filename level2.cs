using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class level2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int ww;
    public int ww1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadData();
        Loadww1();
    }
    /*
    public level2 (Serialization control)
    {
        ww=control.ww;
    }*/
    public void LoadData()
    {
        FileStream fs = new FileStream(Application.persistentDataPath + "/save1.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        ww = int.Parse(sr.ReadLine());
        sr.Close();
        fs.Close();
        if (ww != 1)
        {
            this.transform.localPosition = new Vector3(-1006, -33, 0);
        }
        if (ww >= 1 || ww1 >= 2)
        {
            this.transform.localPosition = new Vector3(25, 14, 0);
            if (ww1 < 2)
            {
                ww1 = ww1 + 2;
            }
            FileStream fs1 = new FileStream(Application.persistentDataPath + "/save2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(ww1);
            sw.Close();
            fs1.Close();
        }
    }
    public void Loadww1()
    {
        FileStream fs1 = new FileStream(Application.persistentDataPath + "/save2.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs1);
        ww1 = int.Parse(sr.ReadLine());
        sr.Close();
        fs1.Close();
    }

}
