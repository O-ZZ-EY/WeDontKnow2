using UnityEngine;
using UnityEngine.UIElements;


public class playerMovement : MonoBehaviour
{
    public SpriteRenderer mySprite;
    public Color MorphQ = Color.magenta;
    public Color MorphW = Color.cyan;
    public Color MorphE = Color.green;
    public GameManagerScript gameManager;
    private bool isDead;
    public GameObject player;
    public Rigidbody2D RB;
    public float jumpForce = 0;

    public bool canPassQ = false;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        mySprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.linearVelocity = Vector3.up * jumpForce;
        }

        if (Input.GetKeyDown("1"))
        {
            mySprite.color = MorphQ;
        }

        if (Input.GetKeyDown("2"))
        {
            mySprite.color = MorphW;
        }

        if (Input.GetKeyDown("3"))
        {
            mySprite.color = MorphE;
        }
    }

    //this is basically how the morph mechanic runs
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("hazard") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
            }
            if (mySprite.color != MorphQ && collision.gameObject.CompareTag("magenta") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
            }
            if (mySprite.color != MorphW && collision.gameObject.CompareTag("cyan") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
            }
            if (mySprite.color != MorphE && collision.gameObject.CompareTag("green") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
            }
        }
    
}
    
    

