using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JapaneseFieldGenerator : MonoBehaviour
{

    public int fieldSize = 10;
    public GameObject tile;

    void Start()
    {

        for (int j = 0; j < fieldSize; j++)
        {
            for (int i = 0; i < fieldSize; i++)
            {
                GameObject btn = Instantiate(tile, new Vector3(i*15-20, j*15+30, 0), Quaternion.identity);
                btn.transform.SetParent(transform);
            }
        }
        transform.position = new Vector3(330, transform.position.y+20, 0);
    }

    void Update()
    {
        
    }
}
