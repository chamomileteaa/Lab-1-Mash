using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //no more than 3 sweets per handfull

    public TMP_Text txtInHand;

    public int sweets;

    public AudioSource pickUp;
    public AudioSource ewVeggie;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sweets = 0;

        txtInHand.text = sweets + " sweets in hand"; //ToString??
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("veggie"))
        {
            ewVeggie.Play();
            UnityEngine.SceneManagement.SceneManager.LoadScene("YouLose");
        }
        else if (collision.CompareTag("sweet"))
        {
            if (sweets < 4)
            {
                collision.transform.SetParent(transform);
                collision.transform.localPosition = Vector3.zero;

                sweets++;
                pickUp.Play();
                txtInHand.text = sweets + " sweets in hand";

            }
            
        }
    }

    public void ResetSweets()
    {
        sweets = 0;
        txtInHand.text = sweets + " sweets in hand";
    }
}
