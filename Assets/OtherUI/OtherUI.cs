using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void Onback()
    {
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(3);
    }
}
