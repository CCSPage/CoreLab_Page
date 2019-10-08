using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{

    public static UIManager Laura;

    public Text Scoretext;
    // Start is called before the first frame update

   

    private void Awake()
    {
        if(Laura = null)
        {
            Laura = this;
        }else if(Laura != this){
            Destroy(gameObject);
        }
    }

    public void ShowNewScore(int score)
    {
        Scoretext.text = score.ToString();
    }
}
