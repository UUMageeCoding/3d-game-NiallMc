using System.Runtime.InteropServices;
using UnityEditor.Rendering;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public Transform teleporter1;
    public GameObject Player;
    Vector3 pos = Vector3.zero;
    CharacterController characterController;
    Quaternion blank;
    bool location = false;
    
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
            location = true;
            teleporter1.transform.GetPositionAndRotation(out pos, out blank);
            Debug.Log(pos);

            Player.transform.position = teleporter1.position;
            
            Debug.Log("Teleport");
        }
    }
    void LateUpdate()
    {
        if (pos != Vector3.zero)
        {
            Player.transform.position = pos;
            location = false;
            pos = Vector3.zero;
            Debug.Log("Teleport");
        }
        

    }

}
