using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChild : MonoBehaviour
{

    public GameObject[] childTypes;
    public Transform[] spawnPositions;

    [HideInInspector] public int typePos;
    [HideInInspector] public int spawnPos;
    [HideInInspector] public GameObject[] children;
    [HideInInspector] public int maxSpawns;

    [HideInInspector] public int currentControl;

    // Start is called before the first frame update
    void Start()
    {
        typePos = 0;
        spawnPos = 0;
        maxSpawns = 4;
        children = new GameObject[maxSpawns];

        currentControl = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        bool isFull = false;
        for (int i = children.Length; i >= 0; i--)
        {
            if(children[i] == null)
            {
                isFull = true;
                spawnPos = i;
            }
        }
        if (!isFull)
        {
            Instantiate(childTypes[typePos], spawnPositions[0].position, new Quaternion(0, 0, 0, 0));
        }
    }

    void DestroyChild(int childPos)
    {
        Destroy(children[childPos]);
        children[childPos] = null;
    }

    /*
    private Vector3 ChoosePos()
    {
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            if (!hitToTest.collider.bounds.Contains(telePosition))
            {
                Debug.Log("point is inside collider");
            }
        }
    }
    */
}
