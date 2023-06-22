using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    // Start is called before the first frame update
    public void sceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
