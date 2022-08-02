using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Row[] rows;
    // Start is called before the first frame update
    void Start()
    {
        rows = new Row[8];
        for (int i = 0; i < rows.Length; i++)
        {
            rows[i] = gameObject.AddComponent<Row>();
            rows[i].setPosition(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
