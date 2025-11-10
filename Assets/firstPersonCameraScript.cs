using UnityEngine;

public class firstPersonCameraScript : MonoBehaviour
{

        [Header("Rotation Settings")]
    [SerializeField] private float rotationSensitivity = 0.01f;
    [SerializeField] private float minVerticalAngle = -30.0f;
    [SerializeField] private float maxVerticalAngle = 60.0f;
    private float currentYRotation;
    private float currentXRotation;

    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        currentYRotation = 0;
        currentXRotation = 0;
    }

    private void LateUpdate()
    {

        currentYRotation += Input.GetAxis("Mouse X") * rotationSensitivity;
        currentXRotation -= Input.GetAxis("Mouse Y") * rotationSensitivity;
        currentXRotation = Mathf.Clamp(currentXRotation, minVerticalAngle, maxVerticalAngle);

        transform.Rotate(currentXRotation, 0f, 0f);

    }
}
