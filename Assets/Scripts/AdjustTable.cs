using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustTable : MonoBehaviour
{
    private bool isRoomSize = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (isRoomSize == false)
            {
                GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
                isRoomSize = true;
            }
            else
            {
                GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
                isRoomSize = false;
            }

        }
    }
}
