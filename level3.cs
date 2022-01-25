using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class level3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int ww;
    public int ww2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadData();
        Loadww2();
    }
    /*
    public level3 (Serialization control)
    {
        ww = control.ww;

    }*/
    public void LoadData()
    {
        FileStream fs = new FileStream(Application.persistentDataPath + "/save1.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        ww = int.Parse(sr.ReadLine());
        sr.Close();
        fs.Close();
        if (ww != 2)
        {
            this.transform.localPosition = new Vector3(-1006, -33, 0);
        }
        if (ww >= 2||ww2>=3)
        {
            this.transform.localPosition = new Vector3(25, -10, 0);
            if (ww2 < 3)
            {
                ww2 = ww2 + 3;
            }
            FileStream fs1 = new FileStream(Application.persistentDataPath + "/save3.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(ww2);
            sw.Close();
            fs1.Close();
        }
        
    }
    public void Loadww2()
    {
        FileStream fs1 = new FileStream(Application.persistentDataPath + "/save3.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs1);
        ww2 = int.Parse(sr.ReadLine());
        sr.Close();
        fs1.Close();
    }
}