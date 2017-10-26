using UnityEngine;
using System.Collections;

public class tobasuGenerator : MonoBehaviour {

    // Use this for initialization
    public GameObject QuadPrefab;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Quad = Instantiate(QuadPrefab) as GameObject;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Quad.GetComponent<tobasu>().shoot(worldDir.normalized*2000);
        }
	}
}
