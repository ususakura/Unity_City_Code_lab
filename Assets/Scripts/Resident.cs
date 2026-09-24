using UnityEngine;

public class Resident : MonoBehaviour
{
    public float targetX = 10f;
    public float targetZ = 5f;
    public float speed = 2f;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool goingToTarget = true;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = new Vector3(targetX, transform.position.y, targetZ);
    }

    void Update()
    {
        if (goingToTarget)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                speed * Time.deltaTime
            );

            if (transform.position == targetPosition)
            {
                goingToTarget = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                startPosition,
                speed * Time.deltaTime
            );

            if (transform.position == startPosition)
            {
                goingToTarget = true;
            }
        }
    }
}