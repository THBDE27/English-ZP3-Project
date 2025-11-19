using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] Button buttonClose;

    private void OnEnable()
    {
        buttonClose.gameObject.SetActive(false);
        StartCoroutine(closeButton(5));
    }

    public void onClick()
    {
        image.gameObject.SetActive(false);
    }

    IEnumerator closeButton(int delai)
    {
        yield return new WaitForSeconds(delai);

        buttonClose.gameObject.SetActive(true);
    }
}
