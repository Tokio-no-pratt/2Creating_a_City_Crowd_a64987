using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DropCylinder : MonoBehaviour
{
    public GameObject obstacle;
    private GameObject[] agents;

    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("agent");
    }

    void Update()
    {
      
        if (Mouse.current == null)
            return;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(mousePos);


            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
            
                Instantiate(obstacle, hitInfo.point, obstacle.transform.rotation);

               
                foreach (GameObject agent in agents)
                {
                  
                }
            }
        }
    }
}
