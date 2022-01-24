using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Text nameText;
    public Text attckText;
    public Text healthText;
    public Text effectText;

    public Image backgroundImage;
    public Card card;       //类型为card的数据
    // Start is called before the first frame update
    void Start()
    {
        ShowCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        nameText.text = card.cardName;
        if (card is MonsterCard)
        {
            var monster = card as MonsterCard;
            attckText.text = monster.attack.ToString();
            healthText.text = monster.healthPoint.ToString();
            effectText.gameObject.SetActive(false);
        }
        else if (card is SpellCard)
        {
            var spell = card as SpellCard;
            effectText.text = spell.effect;
            attckText.gameObject.SetActive(false);
            healthText.gameObject.SetActive(false);
        }
    }
}
