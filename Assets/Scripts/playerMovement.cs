using UnityEngine;
using UnityEngine.UIElements;


public class playerMovement : MonoBehaviour
{
    public SpriteRenderer mySprite;
    public Color MorphQ = Color.magenta;
    public Color MorphW = Color.cyan;
    public Color MorphE = Color.green;
    //the colors are a placeholder, waiting for sprites
    public GameManagerScript gameManager;
    public bool isDead;
    private bool jumpCooldown = false;
    public GameObject player;
    public float playerStartPos;
    public Rigidbody2D RB;
    public float jumpForce = 0;
    public LayerMask layerMaskWorld;

    public bool canPassQ = false;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        mySprite = GetComponent<SpriteRenderer>();
        //layerMask = LayerMask.GetMask("Player", "World");

        playerStartPos = player.gameObject.transform.position.x;

        Ray2D DrawRay = new Ray2D(transform.position, Vector2.down);
    }

    void Update()
    {


        RaycastHit2D Detect = Physics2D.Raycast(transform.position, Vector2.down, 1.2f, layerMaskWorld);

        //float distance = Mathf.Abs(Detect.point.y - transform.position.y);

        Debug.DrawRay(transform.position, Vector2.down, Color.blue);

     //   if (Input.GetKeyDown(KeyCode.Space)) // This is the original jump, I commented it out to test if the new player jump works
      //  {
           // RB.linearVelocity = Vector3.up * jumpForce;
            //allows the player to move up with gravity applied. The player can only jump
        //}


            if (Input.GetKeyDown(KeyCode.Space) && jumpCooldown == false)
            {
                RB.linearVelocity = Vector3.up * jumpForce;
                jumpCooldown = true;
                //allows the player to move up with gravity applied. The player can only jump
            }

        if (Detect) 
        {
            jumpCooldown = false;
            Debug.Log("Reset by: " + Detect.collider.gameObject.name);
        }


        if (Input.GetKeyDown("1"))
        {
            mySprite.color = MorphQ;
            //switches to SpriteQ
        }


        if (Input.GetKeyDown("2"))
        {
            mySprite.color = MorphW;
            //Switches to SpriteW
        }

        if (Input.GetKeyDown("3"))
        {
            mySprite.color = MorphE;
            //switches to SpriteE
        }

        if (player.gameObject.transform.localPosition.x != playerStartPos) // Hey this checks if the player got moved by an object (X axis) and kills them
        {
            isDead = true;
            gameManager.gameOver();
        }
    }

    //this is basically how the morph mechanic runs
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("hazard") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
                //there are colliders tagged with hazard, when touched, end game
            }
            if (mySprite.color != MorphQ && collision.gameObject.CompareTag("magenta") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
                //if the player sprite collides with magenta object and the player sprite/state isn't magenta (MorphQ) end game
            }
            if (mySprite.color != MorphW && collision.gameObject.CompareTag("cyan") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
                //if the player sprite collides with cyan object and the player sprite/state isn't cyan (MorphW) end game
            }
            if (mySprite.color != MorphE && collision.gameObject.CompareTag("green") && !isDead)
            {
                isDead = true;
                gameManager.gameOver();
                //if the player sprite collides with green object and the player sprite/state isn't green (MorphE) end game
            }
        }
    
}
    
    

