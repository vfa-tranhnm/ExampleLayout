using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI txtName;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void SetData()
    {
        float randomNumber = Random.Range(0, 100);
        txtName.text = "item " + randomNumber.ToString();
    }
}
