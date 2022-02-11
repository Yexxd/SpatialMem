using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lista : MonoBehaviour
{
    public GameObject listObject;
    public Transform objectParents, interactableObjects;
    Animator anim;
    public AudioSource list, pick;
    // Update is called once per frame
    Pickable2[] objetos;
    private void Start(){
        anim = gameObject.GetComponent<Animator>();
        objetos = interactableObjects.GetComponentsInChildren<Pickable2>();
        for (int i=0; i<objetos.Length; i++)
        {
            objectParents.GetChild(i).GetComponent<TextMeshPro>().text = "-" + objetos[i].DisplayName;
            objectParents.GetChild(i).gameObject.SetActive(true);
        }
    }
    public void OnPickedObject(string name)
    {
        for(int i=0; i<objetos.Length; i++)
        {
            if (objetos[i].name == name)
            {
                objectParents.GetChild(i).GetComponent<TextMeshPro>().fontStyle = FontStyles.Strikethrough;
                pick.Play();
            }
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("BtnLista")) {
            // Reverse animation play
            if (!listObject.activeSelf)
            {
                anim.SetTrigger("Up");
                list.Play();
            }
            else {
                anim.SetTrigger("Down");
            }
        }
    }
   
}
