using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPlace : MonoBehaviour
{
    float joueurMoney = 0;

    GoBack hasReached;

    int count = 0;
    int placeJoueur;
    bool doOnce = true;

    public void Start()
    {
        hasReached = FindFirstObjectByType<GoBack>();
        joueurMoney = PlayerPrefs.GetFloat("MoneyJoueur", 0);
        Debug.Log("Loaded Player Money = " + joueurMoney);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            print(count);
            count++;
            return;
        }

        if (other.CompareTag("Player"))
        {
            if (!doOnce) return;
            doOnce = false;

            if (hasReached.reachedEndOfPool)
            {
                placeJoueur = count;
                print(count);
                MoneyGain();
                PlayerPrefs.SetFloat("MoneyJoueur", joueurMoney);
                PlayerPrefs.Save();
                SceneManager.LoadScene("Shop");
            }
        }
    }

    void MoneyGain()
    {
        switch (placeJoueur)
        {
            case 0:
                joueurMoney += 20;
                break;
            case 1:
                joueurMoney += 15;
                break;
            case 2:
                joueurMoney += 10;
                break;
            case 3:
                joueurMoney += 5;
                break;
        }
    }
}
