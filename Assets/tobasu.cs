using UnityEngine;
using System.Collections;

public class tobasu : MonoBehaviour {

	// Use this for initialization
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    GameObject Sphere;
    void OnCollisionEnter(Collision other)
    {
        this.Sphere = GameObject.Find("Sphere");
        Destroy(Sphere);
    }
    
	void Start () {
        //shoot(new Vector3(0, 200, 2000));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
