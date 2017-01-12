using UnityEngine;
using System.Collections;

public class FatherMovement : MonoBehaviour {

    public float fatherSpeed;
    public float jumpSpeed;
    public float rotationSpeed;
    public float speed = 60;
    public Level2FloorDelete deleteFloor;
    private bool itemCollision;

    private bool grounded = false;
    // Use this for initialization
    void Start () {
        itemCollision = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(fatherSpeed * Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(fatherSpeed * Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(fatherSpeed * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(fatherSpeed * Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightControl) && grounded == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpSpeed / 2;
            grounded = false;
        }
        if (Input.GetKey(KeyCode.Comma))
        {
            transform.Rotate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Period))
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
    }
       private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            grounded = true;
            
        }
        if (col.gameObject.tag == "Son")
        {
            grounded = true;

        }
    }
    void OnCollisionStay(Collision other)
    {
        itemCollision = true;

        if (itemCollision == true)
        {
            if (other.gameObject.tag == "Deadly Floor")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (deleteFloor.gameObject == null)
                    {

                    }
                    else
                    {
                        Destroy(deleteFloor.gameObject);

                    }

                    Destroy(other.gameObject);
                }

            }
            
        }
    }


}

