using System.Runtime.InteropServices;
using UnityEditor.Rendering;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public Transform teleporter;
    public GameObject Player;
    Vector3 pos;
    CharacterController characterController;
    Quaternion blank;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = Player.GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider door)
    {
        //Debug.Log("collision");
        if (door.CompareTag("Player"))
        {
            teleporter.transform.GetPositionAndRotation(out pos, out blank);
            Debug.Log(pos);

            characterController.enabled = false;
            Player.transform.position = teleporter.position;
            characterController.enabled = true;
            Debug.Log("Teleport");
        }
    }

}
