using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LinkDeleteScript : MonoBehaviour {

    private bool itemCollision;
    
    // Use this for initialization
    void Start () {
        itemCollision = false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionStay(Collision other)
    {
        itemCollision = true;

        if (itemCollision == true)
        {
            if (other.gameObject.tag == "Secret")
            {
                Destroy(other.gameObject);
            }
        }
    }
}
