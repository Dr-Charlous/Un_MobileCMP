using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderDisplay : MonoBehaviour
{
    [SerializeField] GameObject[] Views;

    public void DisplayBigOnes(GameObject obj)
    {
        for (int i = 0; i < Views.Length; i++)
        {
            Views[i].SetActive(false);
        }

        obj.SetActive(true);
    }

    public void Display(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }
}