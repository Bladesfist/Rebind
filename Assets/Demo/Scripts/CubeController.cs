using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Rebind.GetInput("Forward"))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if (Rebind.GetInput("Left"))
        {
            transform.position += (Vector3.right * -1) * Time.deltaTime;
        }
        if (Rebind.GetInput("Right"))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        if (Rebind.GetInput("Back"))
        {
            transform.position += (Vector3.forward * -1) * Time.deltaTime;
        }

    }
}
