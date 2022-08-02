using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private float size = 0.06f;
    private bool hasPiece;

    // positions are relative to bottom left corner of board
    // positions are measured at bottom left corner of square
    public float zPos;  // Row
    public float xPos;  // Column

    // Start is called before the first frame update
    void Start()
    {
    }

    public void setPosition(int z, int x)
    {
        zPos = z * size;
        xPos = x * size;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // x, z  lie within the square
    bool Contained(float x, float z)
    {
        if (x < xPos - (size / 2)) return false;
        if (x >= xPos + (size / 2)) return false;
        if (z < zPos - (size / 2)) return false;
        if (z >= zPos - (size / 2)) return false;
        return true;
    }
}
