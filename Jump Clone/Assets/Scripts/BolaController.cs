using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaController : MonoBehaviour
{
    //acesso a fisica da bola
    public Rigidbody rb;
    public float jumpForce; // força do pulo da bola
    public GameObject splashPrefab; //ter acesso ao prefab splash

    public GameObject panel;
    public GameObject bola;
    public Text txtScore;
    
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        //rb.AddForce(Vector3.up * jumpForce);
        rb.velocity = new Vector3(0,jumpForce,0);

        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f),Quaternion.Euler(90,0,0));
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        //Debug.Log(materialName);
        if(materialName == "PlatformMaterial (Instance)" )
        {
            //continue
        }
        else if(materialName == "PlatformDangerMaterial (Instance)")
        {
            gameManager.GameScore(-5);
        }
        else if(materialName == "LastRing (Instance)")
        {
            //next level
            //Debug.Log("Congratulation");
            txtScore.text = "Score: " + gameManager.txtScore.text;  
            panel.SetActive(true);
            bola.SetActive(false);
        }
    }
}
