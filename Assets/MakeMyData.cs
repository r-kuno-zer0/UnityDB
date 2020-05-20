using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeMyData : MonoBehaviour
{
    public GameObject test_text = null;
    private MyData data;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            data = ScriptableObject.CreateInstance<MyData>();
            data.myName = "Ryo";
            data.hp = Random.Range(10, 50);
            data.attackPower = 10f;
            Text text = test_text.GetComponent<Text>();
            text.text = data.myName + " : " + data.hp + " : " + data.attackPower;
            Debug.Log(data.myName + " : " + data.hp + " : " + data.attackPower);
        }else if (Input.GetButtonDown("Fire2"))
        {
            
            Debug.Log(data.myName + " : " + data.hp + " : " + data.attackPower);
        }
    }
}
