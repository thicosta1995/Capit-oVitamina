using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlvoScript : MonoBehaviour
{
    [SerializeField] private  GameObject Alvo;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Alvo.transform.position = Input.mousePosition;


        Debug.Log(   Alvo.transform.position);
    }
}
