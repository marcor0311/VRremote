using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownControlar : MonoBehaviour
{
    public GameObject PanelSpanish;
    public GameObject PanelEnglish;
    public GameObject PanelPortuguese;
    public void ManageDropdown(int num){

        switch(num)
        {
            case 0:
                PanelSpanish.SetActive(true);
                PanelEnglish.SetActive(false);
                PanelPortuguese.SetActive(false);
                break;
            case 1:
                PanelSpanish.SetActive(false);
                PanelEnglish.SetActive(true);
                PanelPortuguese.SetActive(false);
                break;
            case 2:
                PanelSpanish.SetActive(false);
                PanelEnglish.SetActive(false);
                PanelPortuguese.SetActive(true);
                break;
        }
    }
}
