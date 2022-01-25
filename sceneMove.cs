using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
public class sceneMove : MonoBehaviour
{
    public Image staff_word;
    public Image level_select;
    public Image description;
    Image thanks;
    public void GameStart()
    {
        level_select.transform.localPosition = new Vector3(9, -10, 0);
        //SceneManager.LoadScene("gameScene");
        //Application.LoadLevel(1);
    }
    public void restart()
    {
        SceneManager.LoadScene("startScene");
    }

    public void Level1()
    {
        SceneManager.LoadScene("gameScene");
        //Application.LoadLevel(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene("gameScene2");
        //Application.LoadLevel(1);
    }

    public void Level3()
    {
        SceneManager.LoadScene("gameScene3");
        //Application.LoadLevel(1);
    }
    public void Staff()
    {
        staff_word.transform.localPosition = new Vector3(60, -5, 0);
    }

    public void Description()
    {
        description.transform.localPosition = new Vector3(60, -5, 0);
    }
    public void Close_staff()
    {
        staff_word.transform.localPosition = new Vector3(-1006, 3, 0);
    }

    public void Close_level()
    {
        level_select.transform.localPosition = new Vector3(997, 62, 0);
    }

    public void Close_description()
    {
        description.transform.localPosition = new Vector3(1651, 62, 0);
    }
}
