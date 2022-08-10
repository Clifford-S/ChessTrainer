using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
// I an extending the Piece to provide a coloured piece
public class BlackPiece : Piece
{
    // Start is called before the first frame update
        void Start()
    {
        colour = "black";
        defaultX =32f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
