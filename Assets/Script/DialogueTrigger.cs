using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;

	public void TriggerDialogue (){
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.tag == "ShopKeeper"){
			TriggerDialogue();
		}

    }
    private void OnCollisionExit2D(Collision2D collision){
        FindObjectOfType<DialogueManager>().animator.SetBool("IsOpen", false);
        ShopManager.Instance.shopBtn.interactable = false;
    }
}
