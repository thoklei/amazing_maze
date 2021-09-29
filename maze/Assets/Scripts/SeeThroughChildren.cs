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
        UpdateRenderers();
    }

    // if this thing is hit by raycast, disable all children
    void Update()
    {
        float offsetDist = 10.0f;
        Vector3[] offsets = {offsetDist * Vector3.forward, offsetDist * Vector3.back, offsetDist * Vector3.left, offsetDist * Vector3.right};
        foreach(Vector3 offset in offsets) {

            RaycastHit hitInfo;
            Vector3 dir = gameLogic.GetActivePlayer().transform.position - ( Camera.main.transform.position + offset );
            bool hit = Physics.Raycast(Camera.main.transform.position + offset, dir, out hitInfo, dir.magnitude);
            
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
                        ready = false;
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

    public void UpdateRenderers() {
        // Debug.Log("Updating renderer list, size: " + renderers.Count);
        renderers.Clear();
        foreach(Renderer rend in this.GetComponentsInChildren<Renderer>()) {
            if(rend != null) {
                renderers.Add(rend);
            }
        }
        // Debug.Log("Updated renderer list, size: " + renderers.Count);

    }
}
