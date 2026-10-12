using UnityEngine;

public class PointingNorthScript : MonoBehaviour
{
    public Transform circle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, -Input.compass.trueHeading);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
