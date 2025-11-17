using System.Runtime.InteropServices;
using UnityEditor.Rendering;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public Transform teleporter1;
    public Transform Player;
    Vector3 pos;
    CharacterController characterController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = Player.GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider door)
    {
        Debug.Log("collision");
        if (door.CompareTag("Player"))
        {
            
            characterController.Move(teleporter1.position);
            Debug.Log("Teleport");
        }
    }
}
