using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeController : MonoBehaviour
{
    public int thisPos;
    [HideInInspector] public int currentControl;

    private GameObject newControl;

    // Start is called before the first frame update
    void Start()
    {
        currentControl = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1) && currentControl != thisPos)
        {
            //newControl = GetComponent<SpawnChild>().children[]
        }
    }
}
