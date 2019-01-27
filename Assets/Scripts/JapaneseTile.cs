using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class JapaneseTile : MonoBehaviour
{
    void Start()
    {
    //    this.transform.position = new Vector3( Screen.width / 2,transform.positiom.y, 0);
    }

    void Update()
    {
        
    }
    public void ChangeState()
    {
        if (this.transform.GetComponent<Image>().color == Color.white)
        {
            this.transform.GetComponent<Image>().color = Color.black;
        }
        else if (this.transform.GetComponent<Image>().color == Color.black)
        {
            this.transform.GetComponent<Image>().color = Color.white;
        }

        //transform.GetComponent<Image>().enabled = false;
    }
}
