using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float distance = 10f;
    public float speed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);

        transform.position = startPosition + new Vector3(x, 0, 0);
    }
}