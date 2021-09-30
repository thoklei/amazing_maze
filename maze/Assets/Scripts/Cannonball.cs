using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    GameObject startPoint;
    GameObject endPoint;

    float speed = 0.05f;

    float epsilon = 0.01f;

    float relativeDistance = 0.0f;

    public int damage = 25;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cannonball Position: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, relativeDistance);

        relativeDistance += speed;
        if(Vector3.Distance(this.transform.position, endPoint.transform.position) <= epsilon) {
            Destroy(this.gameObject);
        }
    }

    public void SetPoints(GameObject startPoint, GameObject endPoint) {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
    }

    public void SetProperties(float speed, int damage) {
        this.speed = speed;
        this.damage = damage;
    }
}
