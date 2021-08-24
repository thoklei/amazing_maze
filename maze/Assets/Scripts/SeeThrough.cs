using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThrough : MonoBehaviour
{

    [SerializeField] GameLogic gameLogic;

    private Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        rend = this.GetComponent<Renderer>();
        rend.enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        Vector3 dir = gameLogic.GetActivePlayer().transform.position - Camera.main.transform.position;
        bool hit = Physics.Raycast(Camera.main.transform.position, dir, out hitInfo, dir.magnitude);
        
        if(hit) {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.yellow);
            GameObject wall = hitInfo.collider.gameObject;
            if( wall == this.gameObject) {
                SetVisibility(false);
            } else {
                SetVisibility(true);
            }
        }
    }

    void SetVisibility(bool visible) {
        rend.enabled = visible;
    }

}
