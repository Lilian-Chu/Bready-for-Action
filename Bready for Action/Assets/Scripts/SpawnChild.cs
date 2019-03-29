using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChild : MonoBehaviour
{

    public GameObject[] childTypes;
    public Transform[] spawnPositions;

    [HideInInspector] public int typePos;

    private static float spawnTimeCounter;
    private float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        typePos = 0;
        spawnTimeCounter = 0f;
        cooldown = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (spawnTimeCounter < 0))
        {
            //Instantiate(childTypes[typePos], SpawnChild.ChoosePos(), new Quaternion(0,0,0,0));
            Instantiate(childTypes[typePos], spawnPositions[0].position, new Quaternion(0, 0, 0, 0));
            spawnTimeCounter = cooldown;
        }
        spawnTimeCounter -= Time.deltaTime;
    }


    /*
    private Vector3 ChoosePos()
    {
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            if (!hitToTest.collider.bounds.Contains(telePosition))
            {
                print("point is inside collider");
            }
        }
    }
    */
}
