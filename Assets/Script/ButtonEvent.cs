using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEvent : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData){
        if(transform.gameObject.tag == "ItemOne"){
            if(ShopManager.Instance.items.buyBtn.activeSelf){
                ShopManager.Instance.items.equipBtn.SetActive(true);
                ShopManager.Instance.items.sellBtn.SetActive(false);
                ShopManager.Instance.items.buyBtn.SetActive(false);
            }
            else if(ShopManager.Instance.items.sellBtn.activeSelf){
                ShopManager.Instance.items.buyBtn.SetActive(true);
                ShopManager.Instance.items.sellBtn.SetActive(false);
                ShopManager.Instance.items.equipBtn.SetActive(false);
            }
            else if(ShopManager.Instance.items.equipBtn.activeSelf){
                ShopManager.Instance.items.buyBtn.SetActive(true);
                ShopManager.Instance.items.sellBtn.SetActive(false);
                ShopManager.Instance.items.equipBtn.SetActive(false);
            }
        }
        else if(transform.gameObject.tag == "ItemTwo"){
            if(ShopManager.Instance.itemsTwo.buyBtn.activeSelf){
                ShopManager.Instance.itemsTwo.equipBtn.SetActive(true);
                ShopManager.Instance.itemsTwo.sellBtn.SetActive(false);
                ShopManager.Instance.itemsTwo.buyBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsTwo.sellBtn.activeSelf){
                ShopManager.Instance.itemsTwo.buyBtn.SetActive(true);
                ShopManager.Instance.itemsTwo.sellBtn.SetActive(false);
                ShopManager.Instance.itemsTwo.equipBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsTwo.equipBtn.activeSelf){
                ShopManager.Instance.itemsTwo.buyBtn.SetActive(true);
                ShopManager.Instance.itemsTwo.sellBtn.SetActive(false);
                ShopManager.Instance.itemsTwo.equipBtn.SetActive(false);
            }
        }
        if(transform.gameObject.tag == "ItemThree"){
            if(ShopManager.Instance.itemsThree.buyBtn.activeSelf){
                ShopManager.Instance.itemsThree.equipBtn.SetActive(true);
                ShopManager.Instance.itemsThree.sellBtn.SetActive(false);
                ShopManager.Instance.itemsThree.buyBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsThree.sellBtn.activeSelf){
                ShopManager.Instance.itemsThree.buyBtn.SetActive(true);
                ShopManager.Instance.itemsThree.sellBtn.SetActive(false);
                ShopManager.Instance.itemsThree.equipBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsThree.equipBtn.activeSelf){
                ShopManager.Instance.itemsThree.buyBtn.SetActive(true);
                ShopManager.Instance.itemsThree.sellBtn.SetActive(false);
                ShopManager.Instance.itemsThree.equipBtn.SetActive(false);
            }
        }
        else if(transform.gameObject.tag == "ItemFour"){
            if(ShopManager.Instance.itemFour.buyBtn.activeSelf){
                ShopManager.Instance.itemFour.equipBtn.SetActive(true);
                ShopManager.Instance.itemFour.sellBtn.SetActive(false);
                ShopManager.Instance.itemFour.buyBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemFour.sellBtn.activeSelf){
                ShopManager.Instance.itemFour.buyBtn.SetActive(true);
                ShopManager.Instance.itemFour.sellBtn.SetActive(false);
                ShopManager.Instance.itemFour.equipBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemFour.equipBtn.activeSelf){
                ShopManager.Instance.itemFour.buyBtn.SetActive(true);
                ShopManager.Instance.itemFour.sellBtn.SetActive(false);
                ShopManager.Instance.itemFour.equipBtn.SetActive(false);
            }
        }
        if(transform.gameObject.tag == "ItemFive"){

            if(ShopManager.Instance.itemsFive.buyBtn.activeSelf){
                ShopManager.Instance.itemsFive.equipBtn.SetActive(true);
                ShopManager.Instance.itemsFive.sellBtn.SetActive(false);
                ShopManager.Instance.itemsFive.buyBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsFive.sellBtn.activeSelf){
                ShopManager.Instance.itemsFive.buyBtn.SetActive(true);
                ShopManager.Instance.itemsFive.sellBtn.SetActive(false);
                ShopManager.Instance.itemsFive.equipBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsFive.equipBtn.activeSelf){
                ShopManager.Instance.itemsFive.buyBtn.SetActive(true);
                ShopManager.Instance.itemsFive.sellBtn.SetActive(false);
                ShopManager.Instance.itemsFive.equipBtn.SetActive(false);
            }
        }
        else if(transform.gameObject.tag == "ItemSix"){
            if(ShopManager.Instance.itemsSix.buyBtn.activeSelf){
                ShopManager.Instance.itemsSix.equipBtn.SetActive(true);
                ShopManager.Instance.itemsSix.sellBtn.SetActive(false);
                ShopManager.Instance.itemsSix.buyBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsSix.sellBtn.activeSelf){
                ShopManager.Instance.itemsSix.buyBtn.SetActive(true);
                ShopManager.Instance.itemsSix.sellBtn.SetActive(false);
                ShopManager.Instance.itemsSix.equipBtn.SetActive(false);
            }
            else if(ShopManager.Instance.itemsSix.equipBtn.activeSelf){
                ShopManager.Instance.itemsSix.buyBtn.SetActive(true);
                ShopManager.Instance.itemsSix.sellBtn.SetActive(false);
                ShopManager.Instance.itemsSix.equipBtn.SetActive(false);
            }
        }
    }
}
