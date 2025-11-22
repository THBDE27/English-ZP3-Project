using TMPro;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    public bool reachedEndOfPool = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("murGoBack"))
        {
            print("murfond");
            text.gameObject.SetActive(true);
            reachedEndOfPool = true;
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
