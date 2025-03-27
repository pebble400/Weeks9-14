using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Knight : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public float speed = 2;
    public bool canRun = true;
    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        sr.flipX = (direction < 0);
        animator.SetFloat("movement", Mathf.Abs(direction));

        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }
        
        if(canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
        
    }

    public void AttackHasFinished()
    {
        Debug.Log("The attack animation just finished!");
        canRun = true;
    }
    public void FootHasHitGround()
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
