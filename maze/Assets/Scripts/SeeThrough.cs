using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThrough : MonoBehaviour
{

    [SerializeField] GameLogic gameLogic;
    private Renderer rend;
    private bool ready = true; // whether this wall is ready to be rendered again


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
            GameObject wall = hitInfo.collider.gameObject;
            if( wall == this.gameObject) {
                if(this.rend.enabled) SetInvisible();
            } else {
                if(ready) rend.enabled = true;
            }
        }
    }

    void SetInvisible() {
        rend.enabled = false;
        ready = false;
        StartCoroutine(FadeBackIn());
    }

    protected IEnumerator FadeBackIn()
    {
        yield return new WaitForSeconds(2);
        this.ready = true;
    }

    void SetVisible() {
        rend.enabled = true;

    }

    void SetVisibility(bool visible) {
        rend.enabled = visible;
    }

}
