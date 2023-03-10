using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinningWheel : MonoBehaviour
{
    int randomVal;
    private float timeInterval;
    private bool isCoroutine;
    private int finalAngle;
    public Text buttonText;
   
    public int section;
    float totalAngle;
    public string[] PrizeName;
    public Button SpinButton;
    public GameObject Trigger;
    public float speed;
    public bool isSpin = true;
   

    public void Start()
    {
       
        isCoroutine = true;
      
    }

    
  public void Spinning()
  {
      if (isCoroutine && buttonText.text == "SPIN")
      {
          SpinButton.interactable = false;
         

          StartCoroutine(Spin());
      }


  }
  public void Claim()
  {
      if(isCoroutine && buttonText.text == "CLAIM")
      {
           
            PinTrigger.instance.wTrigger.gift.Drown();

        }
  }
    private float SpinSpeed = 180;
    private float SpeedDecrease = 2f;

    public IEnumerator Spin()
    {
        isCoroutine = false;

        float maxRotate = Random.Range(100, 600);
        float totalRotate = 0;
        

        while (totalRotate < maxRotate)
        {
            transform.Rotate(0,0,SpinSpeed*Time.deltaTime);
            totalRotate += SpinSpeed * Time.deltaTime;
            

            yield return null;
        }

        float t = 0;
        float speed = SpinSpeed;

        while (t < 1)
        {
            t += SpeedDecrease * Time.deltaTime;

            SpinSpeed = Mathf.Lerp(speed, 0, t);

            transform.Rotate(0, 0, SpinSpeed * Time.deltaTime);

            yield return null;
        }

        isCoroutine = true;
        buttonText.text = "CLAIM";

        SpinButton.interactable = true;

        
        
    }
  
}
