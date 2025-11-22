using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] float prixUpgrade;
    [SerializeField] float upgradeValeur;
    [SerializeField] Slider sliderUpgrade;
    [SerializeField] TextMeshProUGUI cashText;
    [SerializeField] TextMeshProUGUI prixUpgradeText;
    [SerializeField] float augmentationCoutUpgrade;
    [SerializeField] TextMeshProUGUI numUpgrade;

    float moneyJoueur;
    float speedJoueur;
    int upSlider = 1;

    void Start()
    {
        moneyJoueur = PlayerPrefs.GetFloat("MoneyJoueur", 0);
        speedJoueur = PlayerPrefs.GetFloat("JoueurSpeed", 15);
        cashText.text = $"{moneyJoueur}$";
        prixUpgradeText.text = $"Le cout de l'upgrade est de : {prixUpgrade}";
        numUpgrade.text = $"{sliderUpgrade.value}";
    }

    public void OnClick()
    {
        if(moneyJoueur >= prixUpgrade)
        {
            if(sliderUpgrade.value < 5)
            {
                moneyJoueur -= prixUpgrade;
                cashText.text = $"{moneyJoueur}$";

                speedJoueur += upgradeValeur;
                prixUpgrade += augmentationCoutUpgrade;
                prixUpgradeText.text = $"Le cout de l'upgrade est de : {prixUpgrade}";

                sliderUpgrade.value += upSlider;
                numUpgrade.text = $"{sliderUpgrade.value}";

                PlayerPrefs.SetFloat("JoueurSpeed", speedJoueur);
                PlayerPrefs.SetFloat("MoneyJoueur", moneyJoueur);

                print(PlayerPrefs.GetFloat("JoueurSpeed", 15));

                PlayerPrefs.Save();
            }
        }
        else
        {
            StartCoroutine(erreurPrix());
        }
    }

    IEnumerator erreurPrix()
    {
        prixUpgradeText.text = $"Vous n'avez pas assez d'argent!!";
        prixUpgradeText.color = Color.red;

        yield return new WaitForSeconds(0.5f);

        prixUpgradeText.text = $"Le cout de l'upgrade est de : {prixUpgrade}";
        prixUpgradeText.color = Color.black;
    }
}
