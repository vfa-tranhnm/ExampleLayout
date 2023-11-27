using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ListItem : MonoBehaviour
{
    [SerializeField] ScrollRect scroll;
    [SerializeField] RectTransform m_content;
    [SerializeField] ItemUI itemUI;
    [SerializeField] Button Back;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnDeleteItem()
    {
        //Debug.LogError("Delete");

        int count = m_content.childCount;
        Destroy(m_content.GetChild(0).gameObject);
        scroll.viewport.ForceUpdateRectTransforms();
    }
    public void OnAddItem()
    {
        //Debug.LogError("Add");

        ItemUI item = Instantiate(itemUI,m_content);
        item.SetData();
        scroll.viewport.ForceUpdateRectTransforms();
    }
    public void Onback()
    {
        //Debug.LogError("back");
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(2);
    }
    public void OnbackHorizontal()
    {
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(4);
    }
}
