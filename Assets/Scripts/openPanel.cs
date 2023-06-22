using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPanel : MonoBehaviour
{
    public GameObject Panel;
    public void open()
    {
        Panel.SetActive(true);
    }
    public void close()
    {
        Panel.SetActive(false);
    }
}
