using System.Collections;
using System.Collections.Generic;
using Invector.vCharacterController;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    private float a = 0, b = 5, c = 0;
	private int i = 0,countlife = 10;
	public TextMeshProUGUI countLife;
    public GameObject looseTextObject;
    public GameObject ReplayButton;
    public GameObject QuitButton;
    public GameObject winTextObject;


    void  Start (){
		// get the distance to ground
		countlife = 10;
		SetCountLife();
        looseTextObject.SetActive(false);
        winTextObject.SetActive(false);
        ReplayButton.SetActive(false);
        QuitButton.SetActive(false);
	}
    void SetCountLife(){
		countLife.text = "Life: " + countlife.ToString();
        if (countlife <= 0)
        {
            looseTextObject.SetActive(true);
            ReplayButton.SetActive(true);
            QuitButton.SetActive(true);

        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Moutain")
        {
            if (countlife > 0)
            {
                countlife--;
            }
			
            SetCountLife();
            i++;
            gameObject.GetComponent<vThirdPersonController>().transform.gameObject.SetActive(false);
            gameObject.GetComponent<vThirdPersonController>().transform.position = new Vector3(a, b, c);
            gameObject.GetComponent<vThirdPersonController>().transform.gameObject.SetActive(true);
            Debug.Log("Moutain "+i);
            //Die();
			
            
        }
        if (collision.gameObject.tag == "Home" && countlife > 0)
        {
            winTextObject.SetActive(true);
            ReplayButton.SetActive(true);
            QuitButton.SetActive(true);
        }
        
    }

    void OnTriggerEnter (Collider collider)
    {

        if (collider.gameObject.tag == "Flag1")
        {
            Debug.Log("Flag1");
            a = 0f;
            b = 4.5f;
            c= 56.5f;
			
        }
        if (collider.gameObject.tag == "Flag2")
        {
            Debug.Log("Flag2");
            a = -22f;
            b = 2f;
            c= 76f;
        }
        if (collider.gameObject.tag == "Flag3")
        {
            Debug.Log("Flag3");
            a = -43f;
            b = 2f;
            c= 76f;
        }
        if (collider.gameObject.tag == "Flag4")
        {
            Debug.Log("Flag4");
            a = -73f;
            b = 4.5f;
            c= 77f;
        }
        if (collider.gameObject.tag == "Flag5")
        {
            Debug.Log("Flag5");
            a = -61f;
            b = 11.5f;
            c= 31f;
        }
        if (collider.gameObject.tag == "Flag6")
        {
            Debug.Log("Flag6");
            a = -58f;
            b = 30f;
            c= 21.5f;
        }
        Debug.Log(a + " " + b+ " " + c);
    }
    
}
