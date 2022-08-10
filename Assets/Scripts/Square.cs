using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private float size;
    private bool hasPiece;

    // positions are relative to bottom left corner of board
    // positions are measured at bottom left corner of square
    private float zPos;  // Row
    private float xPos;  // Column

    // Start is called before the first frame update
    void Start()
    {
    }
    // POLYMORPHISM
    // will accpet a float or an int 
    public void setSize(float sizeF)
    {
        size = sizeF;
    }
// POLYMORPHISM
// will accept a float or an int 
public void setSize(int sizeI)
    {
        size = (float)sizeI;
    }

    // ENCAPSULATION
    public void setPosition(int z, int x)
    {
        zPos = z * size;
        xPos = x * size;
    }
    // ENCAPSULATION
    public float getX()
    {
        return xPos;
    }
    // ENCAPSULATION
    public float getZ()
    {
        return zPos;
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
