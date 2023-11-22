using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChatElement : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtChat;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetData(string chat)
    {
        txtChat.text = chat;
    }
}
