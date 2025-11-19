using UnityEngine;

public class GenderSwapping : MonoBehaviour
{
    [SerializeField] GameObject male;
    [SerializeField] GameObject female;
    bool isMale = true;

    private void Start()
    {
        female.SetActive(false);
    }

    public void GenderSwap()
    {
        if (isMale)
        {
            male.SetActive(false);
            female.SetActive(true);
            isMale = false;
        }
        else
        {
            male.SetActive(true);
            female.SetActive(false);
            isMale = true;
        }
    }
}
