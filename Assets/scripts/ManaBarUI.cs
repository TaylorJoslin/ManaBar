using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBarUI : MonoBehaviour
{
    [SerializeField] AutoFireBall fireballScript;
    [SerializeField] Image mana;


    // Update is called once per frame
    void Update()
    {
        float fillAmount = fireballScript.GetCurrentMana() / fireballScript.maxMana;
        mana.fillAmount = fillAmount;
    }
}
