using UnityEngine;
using System.Collections;

public class tobasu : MonoBehaviour {
   

    // Use this for initialization
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    GameObject Sphere;
    GameObject Sphere2;
    GameObject Sphere3;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<SphereCollider>())
        {
            Destroy(other.gameObject);
        }
        //this.Sphere = GameObject.Find("Sphere");
        //Destroy(Sphere);
        //this.Sphere = GameObject.Find("Sphere2");
        //Destroy(Sphere);
        //this.Sphere = GameObject.Find("Sphere3");
        //Destroy(Sphere);
    }
    
	void Start () {
        //shoot(new Vector3(0, 200, 2000));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
