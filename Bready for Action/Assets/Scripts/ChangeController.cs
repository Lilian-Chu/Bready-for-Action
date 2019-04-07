using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeController : MonoBehaviour
{
    //thisPos is the position of the GameObject this script is attached to.
    //Determined by this object's position in children
    public int thisPos;

    private CurrentController current;

    // Start is called before the first frame update
    void Start()
    {
        current = GameObject.FindWithTag("Player").GetComponent<CurrentController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0 + thisPos))
        {
            if (current.GetComponent<SpawnChild>() != null)
            {
                current.GetComponent<SpawnChild>().enabled = false;
            }
            if (this.gameObject.GetComponent<SpawnChild>() != null)
            {
                this.gameObject.GetComponent<SpawnChild>().enabled = true;
            }

            current.currentControl.GetComponent<PlayerControllerNew>().enabled = false;
            GetComponent<PlayerControllerNew>().enabled = true;



            current.current = thisPos;
            current.currentControl = this.gameObject;
            //Debug.Log(thisPos);
        }
    }
}
