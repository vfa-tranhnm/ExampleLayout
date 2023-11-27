using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void OnChat()
    {
        SceneManager.LoadScene("Chat");
    }
    public void OnListItem()
    {
        SceneManager.LoadScene("ListItem");
    }
    public void OnHorizontal()
    {
        SceneManager.LoadScene("Horizontal");
    }
    public void OnOther()
    {
        SceneManager.LoadScene("OtherUI");
    }
}
