using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public Tweener tweener;
    private float gridSize = 0.35f;
    // Start is called before the first frame update
    private char lastInput;
    private char currentInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            lastInput = 'W';
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            lastInput = 'A';
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            lastInput = 'S';
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            lastInput = 'D';
        }
                if (lastInput == 'W')
                {
                    //check north 
                    if (checkIfPosEmpty(this.gameObject.transform.position += new Vector3(0, gridSize, 0)))
                    {
                        Vector3 targetPos = this.gameObject.transform.position + new Vector3(0, gridSize, 0);
                        currentInput = lastInput;
                        tweener.addTween(this.gameObject.transform, gameObject.transform.position, targetPos, 1.0f);
                lastInput = ' ';
                    }
                }
                if (lastInput == 'A')
                {
                    //check west
                    if (checkIfPosEmpty(this.gameObject.transform.position += new Vector3(-gridSize, 0, 0)))
                        {
                        Vector3 targetPos = this.gameObject.transform.position + new Vector3(-gridSize, 0, 0);
                        currentInput = lastInput;
                        tweener.addTween(this.gameObject.transform, gameObject.transform.position, targetPos, 1.0f);
                lastInput = ' ';
            }

                }
                if (lastInput == 'S')
                {
                    //check south
                    if (checkIfPosEmpty(this.gameObject.transform.position += new Vector3(0, -gridSize, 0)))
                        {
                        Vector3 targetPos = this.gameObject.transform.position + new Vector3(0, -gridSize, 0);
                        currentInput = lastInput;
                        tweener.addTween(this.gameObject.transform, gameObject.transform.position, targetPos, 1.0f);
                lastInput = ' ';
            }
                }
                if (lastInput == 'D')
                {
                    //check east
                    if (checkIfPosEmpty(this.gameObject.transform.position += new Vector3(gridSize, 0, 0)))
                    {
                        Vector3 targetPos = this.gameObject.transform.position + new Vector3(gridSize, 0, 0);
                        currentInput = lastInput;
                        tweener.addTween(this.gameObject.transform, gameObject.transform.position, targetPos, 1.0f);
                lastInput = ' ';
            }
                }

    }

    public bool checkIfPosEmpty(Vector3 targetPos)
    {
        GameObject[] allWalls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (GameObject current in allWalls)
        {
            if (current.transform.position == targetPos)
                return false;
        }
        return true;
    }
}
