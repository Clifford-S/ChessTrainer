using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public GameObject newPiece;
    public GameObject board;
    public bool hitIt;

    // Start is called before the first frame update
    void Start()
    {
        board = GameObject.Find("Chess Board Play Surface");
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray,  out hit))
            {
                hitIt = true;
               // Debug.Log(hit.point);
                newPiece.transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            }
        }
    }

    public void Spawn(GameObject pieceName)
    {
        GameObject oldPiece = GameObject.Find(pieceName.name);
        if(oldPiece.GetComponent<Piece>().onBoard == false)
        {
            newPiece = Instantiate(oldPiece, new Vector3(0, 1.3333f, 0), oldPiece.transform.rotation); //as GameObject;
            newPiece.GetComponent<Piece>().onBoard = true;
        }
    }
}
