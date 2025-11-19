using TMPro;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    bool reachedEndOfPool = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("murGoBack"))
        {
            print("murfond");
            text.gameObject.SetActive(true);
            reachedEndOfPool = true;
        }

        if (reachedEndOfPool)
        {
            if (other.CompareTag("Finish"))
            {

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("murGoBack"))
        {
            text.gameObject.SetActive(false);
        }
    }
}
