using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private Image checkpointUI;
    public bool activated;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (!activated)
        {
            if (other.CompareTag("Player")){
                // other.GetComponent<Player>().ChangeRespawnPoint(this.transform);
                activated = true;
                // set UI to green background
                checkpointUI.color = Color.green;
            }
        }
    }
}
