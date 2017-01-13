using UnityEngine;
using System.Collections;


public class PlayerMove : MonoBehaviour
{

    private CardboardHead cardboardHead;
    private bool isWalk = false;
    public static bool isOperate = false;

    public AudioClip[] footStepAudioClip;

    private AudioSource audio;
    void Start()
    {
        isOperate = false;
        cardboardHead = GetComponentInChildren<CardboardHead>();
        Cardboard.SDK.OnTrigger += MoveTrigger;
        audio = this.GetComponent<AudioSource>();
    }

    public void MoveTrigger()
    {
        Move();
    }


    void Update()
    {
       
    }

    void Move()
    {
        if (!isOperate)
        {
            if (isWalk)
            {
                isWalk = false;
                StopCoroutine("PlayAudio");
                
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;

            }
            else
            {
                isWalk = true;
                StartCoroutine("PlayAudio");

             
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                Vector3 direction = cardboardHead.Gaze.direction.normalized;
                direction.y = 0f;
                this.GetComponent<Rigidbody>().AddForce(direction * 35f);

            }
        }


    }

    IEnumerator PlayAudio()
    {
        while (isWalk)
        {


            foreach (AudioClip item in footStepAudioClip)
            {


                if (isWalk)
                {
                    audio.clip = item;
                    audio.Play();
                    yield return new WaitForSeconds(item.length + 0.8f);

                }
                else
                {

                    Debug.Log("Break");
                    yield break;
                }

            }


        }
    }


    void OnCollisionEnter()
    {
        this.GetComponent<Rigidbody>().freezeRotation = true;
    }
}
