using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SecondCarControler : MonoBehaviour
{
    [SerializeField] float vitesse2 = 2f;
    [SerializeField] float rotation2 = 0.1f;
    public float CheckpointCounter2 = 0f;
    public GameObject winPanel2;
    public float timer = 180f;
    public GameObject loosePanel;
    public Text MyText;
    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z"))
        {
            transform.Translate(0, 0, vitesse2);
            if (Input.GetKey("d"))
            {
                transform.Rotate(new Vector3(0f, rotation2, 0f));
            }
            if (Input.GetKey("q"))
            {
                transform.Rotate(new Vector3(0f, -rotation2, 0f));
            }
        }
         if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -vitesse2);
            if (Input.GetKey("d"))
            {
                transform.Rotate(new Vector3(0f, rotation2, 0f));
            }
            if (Input.GetKey("q"))
            {
                transform.Rotate(new Vector3(0f, -rotation2, 0f));
            }
        }



        if (CheckpointCounter2 == 9)
        {
            winPanel2.SetActive(true);

        }

        MyText.text = "" + CheckpointCounter2;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Checkpoint")
        {
            CheckpointCounter2 += 1;
            other.tag = "UsedCheckpoint";
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Taxi")
        {
            loosePanel.SetActive(true);
        }
    }
}
