using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftDrowning : MonoBehaviour 
{
    public GameObject gift;

    private Rigidbody2D rb;

   

    [SerializeField]
    public int drowningSpeed = 15;

    public int time = 30;

   
    public void Drown()
    {
        rb.gravityScale = 10;
        StartCoroutine(drowning());
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;

    }
   

   IEnumerator drowning()
    {
        transform.parent.GetChild(1).gameObject.SetActive(false);
        for(int i=0; i < time; i++)
        {
            transform.localScale = new Vector3(transform.localScale.x + 0.05f, transform.localScale.y + 0.05f, transform.localScale.z + 0.05f);
            yield return new WaitForSeconds(0.0333f);
        }

        Debug.Log(transform.parent.tag);
                   
        Destroy(gameObject);
            
   }
        


        
 }

