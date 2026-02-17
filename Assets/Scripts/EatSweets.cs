using UnityEngine;
using TMPro;


public class EatSweets : MonoBehaviour
{
    public TMP_Text txtSweetsEaten;

    public int sweetsEaten;

    public GameManager gameManager;

    public AudioSource munch;

    //place on boy's face



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sweetsEaten = 0;

        txtSweetsEaten.text = sweetsEaten + " sweets eaten";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("sweet"))
        {
            
            sweetsEaten++;
            txtSweetsEaten.text = sweetsEaten + " sweets eaten";

            
            if (sweetsEaten >= 6)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("YouWin");

            }
            Destroy(collision.gameObject);
            munch.Play();

            gameManager.ResetSweets();

        }
    }
    


}
