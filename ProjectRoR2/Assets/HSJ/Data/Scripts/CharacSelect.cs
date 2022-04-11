using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;



public class CharacSelect : MonoBehaviour
{
    public enum STATE
    {
        LOADER, COMMANDO, CLICK, NONE
    }
    public STATE myChar = STATE.NONE;    
    public GameObject C;
    public GameObject L;
    public Button CB;
    public Button LB;
    public TMPro.TMP_Text CharName;

    void Start()
    {
        ChangeState(STATE.CLICK);



    }

    // Update is called once per frame
    void Update()
    {
        StatProceses();
        
    }

    public void CommandoSel()
    {
        if (myChar == STATE.COMMANDO)
        {
            ChangeState(STATE.CLICK);
        }
        if (!(myChar == STATE.COMMANDO))
        {
            ChangeState(STATE.COMMANDO);
        }
    }
    public void LoaderSel()
    {
        if (myChar == STATE.LOADER)
        {
            ChangeState(STATE.CLICK);
        }
        if (!(myChar == STATE.LOADER))
        {
            ChangeState(STATE.LOADER);
        }
    }
    void ChangeState(STATE c)
    {
        if (myChar == c) return;
        myChar = c;
        switch (myChar)
        {
            case STATE.COMMANDO:
                C.SetActive(true);
                L.SetActive(false);
                CharName.text = "Commando";
                ChangeState(STATE.CLICK);
                break;
            case STATE.LOADER:
                L.SetActive(true);
                C.SetActive(false);
                CharName.text = "Loader";
                ChangeState(STATE.CLICK);
                break;
            case STATE.CLICK:
                
                break;
            case STATE.NONE:
                break;
                
        }
    }
    void StatProceses()
    {
        switch (myChar)
        {
            case STATE.COMMANDO:
               
                break;
            case STATE.LOADER:
               
                break;
            case STATE.CLICK:
                CB.onClick.AddListener(CommandoSel);
                LB.onClick.AddListener(LoaderSel);
                break;
            case STATE.NONE:
                break;
        }
    }
    
   
}
