using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Occlusion : MonoBehaviour
{
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
        

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("dsadsd");
        if (col.gameObject.tag == "camCol")
        {

            Debug.Log("dsadsd");
            obj.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "camCol")
        {
            obj.SetActive(false);
        }
    }

}