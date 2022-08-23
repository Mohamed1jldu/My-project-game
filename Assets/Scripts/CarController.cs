using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarController : MonoBehaviour
{
    [SerializeField]float vitesse = 2f;
    [SerializeField] float rotation = 0.1f;
    public GameObject winPanel;
    Vector3 direction;
    Rigidbody rb;
    GameObject taxi;
    // Start is called before the first frame update
    void Start()
    {
        taxi = GameObject.Find("Taxi");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = taxi.transform.position;
        if (!taxi.transform)
        {
            direction = Vector3.zero;
            return;
        }
        else
        {
            //direction = taxi.transform.position - transform.position;
            //rb.rotation = Quaternion.LookRotation(direction);
            //rb.angularVelocity = Vector3.zero;
            //rb.MovePosition(taxi.transform.position);
        }

        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Taxi")
        {
            winPanel.SetActive(true);
        }
    }
}
