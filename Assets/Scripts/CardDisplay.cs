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
    public Card card;       //����Ϊcard������
    // Start is called before the first frame update
    void Start()
    {
        
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

        }
    }
}
