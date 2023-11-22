using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField] GameObject Chat;
    [SerializeField] GameObject ListItem;
    // Start is called before the first frame update
    void Start()
    {
        Chat.SetActive(false);
        ListItem.SetActive(false);
    }

    public void OnChat()
    {
        Chat.SetActive(true);
        ListItem.SetActive(false);
    }
    public void OnListItem()
    {
        Chat.SetActive(false);
        ListItem.SetActive(true);
    }
}
