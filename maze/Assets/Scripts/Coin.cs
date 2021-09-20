using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 50 * Time.deltaTime, 0, Space.Self); // coin rotates :)
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Player")) {
            Audiomanager.instance.Play("coin");
            Destroy(this.gameObject);
        }
    }

    void OnDestroy() {
        SeeThroughChildren stc = this.GetComponentInParent<SeeThroughChildren>();
        if(stc != null) stc.UpdateRenderers();
    }
}
