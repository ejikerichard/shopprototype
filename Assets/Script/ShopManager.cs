using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public static ShopManager Instance;

    [SerializeField] GameObject shopPanel;
    public Button shopBtn;

    public RuntimeAnimatorController blackAnim, RedAnim, JackAnim;

    public bool equipedItemOne, equipedItemTwo, equipedItemThree;

    #region Item class variables
    [SerializeField] public ItemsOne items;
    [SerializeField] public ItemsTwo itemsTwo;
    [SerializeField] public ItemsThree itemsThree;
    [SerializeField] public ItemFour itemFour;
    [SerializeField] public ItemsFive itemsFive;
    [SerializeField] public ItemsSix itemsSix;
    #endregion

    KeyCode shopExit_Btn = KeyCode.Escape;

    private void Awake(){
        Instance = this;
    }
    private void Start(){
        equipedItemThree = true;
    }
    private void Update(){
        OnExitShop();
    }

    void OnExitShop(){
        if(Input.GetKey(shopExit_Btn) && shopPanel.activeSelf){
            shopPanel.SetActive(false);
            shopBtn.interactable = false;
        }
    }

    public void OnShop(){
        shopPanel.SetActive(true);
        shopBtn.interactable = false;
    }
}

#region Items Class
[System.Serializable]
public class ItemsOne
{
    public GameObject sellBtn, buyBtn, equipBtn;
}

[System.Serializable]
public class ItemsTwo{
    public GameObject sellBtn, buyBtn, equipBtn;
}

[System.Serializable]
public class ItemsThree{
    public GameObject sellBtn, buyBtn, equipBtn;
}

[System.Serializable]
public class ItemFour{
    public GameObject sellBtn, buyBtn, equipBtn;
}

[System.Serializable]
public class ItemsFive{
    public GameObject sellBtn, buyBtn, equipBtn;
}

[System.Serializable]
public class ItemsSix{
    public GameObject sellBtn, buyBtn, equipBtn;
}
#endregion
