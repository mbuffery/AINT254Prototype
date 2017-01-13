using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SonMovement : MonoBehaviour {
    public float sonSpeed;
    public float jumpSpeed;
    public float rotationSpeed;
    public float speed = 60;
    private bool itemCollision;
    [SerializeField]
    public LinkDeleteScript secret1;
    [SerializeField]
    public Level2 secret2;
    [SerializeField]
    public ThirdLevel secret3;



    private bool grounded = false;
    
	// Use this for initialization
	void Start () {

        itemCollision = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(sonSpeed * Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(sonSpeed * Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(sonSpeed * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(sonSpeed * Vector3.back * Time.deltaTime);
        }
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpSpeed;

            grounded = false;
        }
        if (Input.GetKey(KeyCode.Q))
        {            
            transform.Rotate(Vector3.down * speed * Time.deltaTime);
        }
        if  (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }

      }
    private void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Floor")
        {
            grounded = true;
        }

        if(col.gameObject.tag == "Father")
        {
            grounded = true;
        }
        if(col.gameObject.tag == "Deadly Floor")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void OnCollisionStay(Collision other)
    {
        itemCollision = true;
        
        if (itemCollision == true)
        {
            
            if (other.gameObject.tag == "level1last")
            {
                if(Input.GetKeyDown(KeyCode.F))
                {
                    SceneManager.LoadScene("Level2");
                }
            }
            if (other.gameObject.tag == "Secret")
            {
                if(Input.GetKeyDown(KeyCode.F))
                {
                    if (secret1.gameObject == null)
                    {

                    }
                    else
                    {
                        Destroy(secret1.gameObject);

                    }
                    
                    Destroy(other.gameObject);
                }
                
            }
            if (other.gameObject.tag == "Level2:2")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (secret2.gameObject == null)
                    {

                    }
                    else
                    {
                        Destroy(secret2.gameObject);

                    }
                    Destroy(other.gameObject);
                }

            }
            if (other.gameObject.tag == "HelpSon")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (secret3.gameObject == null)
                    {

                    }
                    else
                    {
                        Destroy(secret3.gameObject);

                    }

                    Destroy(other.gameObject);
                }

            }
        }
    }    
}
