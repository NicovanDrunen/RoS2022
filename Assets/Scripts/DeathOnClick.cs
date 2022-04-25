using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnClick : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            animator.SetTrigger("Death");
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
