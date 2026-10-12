using UnityEngine;

public class CompassScript : MonoBehaviour
{
    public Transform compass;

    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0,0, -Input.compass.magneticHeading);
    }
}
