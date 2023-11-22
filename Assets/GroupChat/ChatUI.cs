using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChatUI : MonoBehaviour
{
    [SerializeField] ChatElement chatleft;
    [SerializeField] ChatElement chatright;
    [SerializeField] RectTransform m_content;
    [SerializeField] TMP_InputField inputChat;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnSendChat()
    {

        System.Random gen = new System.Random();
        bool result = gen.Next(100) < 50 ? true : false;
        float height = m_content.rect.height;
        if (inputChat.text.Trim()!= string.Empty)
        {
            if(result)
            {
                ChatElement left = Instantiate(chatleft, m_content);
                left.gameObject.SetActive(true);
                left.SetData(inputChat.text);
                
            }
            else
            {
                ChatElement right = Instantiate(chatright, m_content);
                right.gameObject.SetActive(true);
                right.SetData(inputChat.text);
            }
            inputChat.text = "";
            float offset = m_content.rect.height - height;
            //m_content.transform.position.Set(m_content.transform.position.x, m_content.transform.position.y + offset, m_content.transform.position.z);
            m_content.rect.position.Set(m_content.transform.position.x, m_content.transform.position.y + offset);
        }
    }
}
