using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuItemSetting : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [MenuItem("MyMenu/Anything")]
    static void Penguin()
    {
        Debug.Log("Hello!");
    }
}
