using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject realBottle;
    private Animator animator ;
    public GameObject bottle;
    public GameObject leftHand;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    
    public void OnEat() 
    {
        animator.SetBool("eat",true);
        
        bottle.SetActive(false);
        realBottle.SetActive(true);
    }
    public void OffEat()
    {
        animator.SetBool("eat",false);
    }
    public void Blink()
    {
        animator.SetTrigger("Blink");
    }
}
