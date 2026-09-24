using UnityEngine;

public class LanternSway : MonoBehaviour
{
    public float swayAngle = 2f;
    public float swaySpeed = 0.5f;

    private Quaternion startRotation;
    private float offset;

    void Start()
    {
        startRotation = transform.localRotation;
        offset = Random.Range(0f, 5f);
    }

    void Update()
    {
        float angle = Mathf.Sin(Time.time * swaySpeed + offset) * swayAngle;

        transform.localRotation =
            startRotation * Quaternion.Euler(0, angle, 0);
    }
}