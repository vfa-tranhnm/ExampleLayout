using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ListItem : MonoBehaviour
{
    [SerializeField] RectTransform m_content;
    [SerializeField] ItemUI itemUI;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnDeleteItem()
    {
        int count = m_content.childCount;
        Destroy(m_content.GetChild(count -1));
    }
    public void OnAddItem()
    {
        ItemUI item = Instantiate(itemUI,m_content);
        item.SetData();
    }
}
