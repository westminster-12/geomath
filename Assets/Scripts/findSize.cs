using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findSize : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Vector3 size = GetComponent<Collider>().bounds.size;
        Debug.Log(transform.localScale.x);
    }
}
