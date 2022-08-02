using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    public int rowNumb;
    public Square[] squares;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void setPosition(int z)
    {
        rowNumb = z;
        squares = new Square[8];
        for (int i = 0; i < squares.Length; i++)
        {
            squares[i] = gameObject.AddComponent<Square>();
            squares[i].setPosition(rowNumb, i);
        }
    }
}
