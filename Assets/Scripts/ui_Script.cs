using System;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ui_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //bool MainIsClicked = true;
    //public GameObject level1;
    //public GameObject level2;
    //public TextMeshProUGUI Continue;
    //void Start()
    //{
    //    level1.SetActive(false);
    //    level2.SetActive(false);
    //}

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Level1");
        }else if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Level2");
        }
    }

    //void StartGame()
    //{
    //    if (MainIsClicked && Input.anyKey)
    //    {
    //        Continue.enabled = false;
    //        level1.SetActive(true);
    //        level2.SetActive(true);
    //        MainIsClicked = false;
    //    }
    //}

    //public void SelectLevel(string level)
    //{
    //    SceneManager.LoadScene(level);
    //}
    // Update is called once per frame
    //void Update()
    //{

    //}


}
