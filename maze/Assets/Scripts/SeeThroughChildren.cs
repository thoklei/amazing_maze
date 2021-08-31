using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThroughChildren : MonoBehaviour
{

    [SerializeField] GameLogic gameLogic;

    [SerializeField] GameObject baseplate; // the base plate of the wall
    private List<Renderer> renderers;
    private bool ready;

    void Start()
    {
        renderers = new List<Renderer>();
        renderers.AddRange(this.GetComponentsInChildren<Renderer>());
    }

    // if this thing is hit by raycast, disable all children
    void Update()
    {
        RaycastHit hitInfo;
        Vector3 dir = gameLogic.GetActivePlayer().transform.position - Camera.main.transform.position;
        bool hit = Physics.Raycast(Camera.main.transform.position, dir, out hitInfo, dir.magnitude);
        
        if(hit) {
            GameObject wall = hitInfo.collider.gameObject;
            if( wall == baseplate) {
                foreach(Renderer rend in this.renderers) {
                    SetInvisible(rend);
                }
                StartCoroutine(FadeBackIn());
            }else {
                if(ready) {
                    foreach(Renderer rend in this.renderers) {
                        SetVisible(rend);
                    } 
                }
            }
        }
    }

    void SetInvisible(Renderer rend) {
        rend.enabled = false;
        ready = false;
    }

    void SetVisible(Renderer rend) {
        rend.enabled = true;
    }

    protected IEnumerator FadeBackIn()
    {
        yield return new WaitForSeconds(2);
        ready = true;
    }
}
