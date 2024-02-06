using UnityEngine;
using UnityEngine.UI;

public class checkScore : MonoBehaviour
{
    public Text[] allText;
    void Start()
    {
        CheckScore(PlayerPrefs.GetInt("score"));
        
    }
    private void CheckScore(int score)
    {
        if (score >= 10)
            allText[0].text = "unlock";
        if (score >= 20)
            allText[1].text = "unlock";
        if (score >= 30)
            allText[2].text = "unlock";
        if (score >= 40)
            allText[3].text = "unlock";
        if (score >= 50)
            allText[4].text = "unlock";
        if (score >= 60)
            allText[5].text = "unlock";
        if (score >= 70)
            allText[6].text = "unlock";
        if (score >= 80)
            allText[7].text = "unlock";
        if (score >= 110)
            allText[8].text = "unlock";

    }

}
