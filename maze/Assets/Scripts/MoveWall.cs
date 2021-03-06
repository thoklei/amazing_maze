using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] private Material groundMat;
    public OnOffButton redbutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!redbutton.isActiveAndEnabled && this.transform.localPosition.y > -2)
        {
            transform.Translate(Vector3.left * 2 * Time.deltaTime);
        }

        if (this.transform.localPosition.y < -2f)
        {
            foreach (Transform child in transform)
                child.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
