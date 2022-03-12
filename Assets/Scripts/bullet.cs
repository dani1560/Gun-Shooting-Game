using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    AudioSource currentAudioSource;
    Text scoreCard;

    public GameObject bulletObject;
    GameObject tempBullet;
    GameObject[] reload;

    public AudioClip gunShot;
    public AudioClip emptyShot;
    public AudioClip gunReload;

    public static int score; 
    int bulletRange;
  
    void Start()
    {
        currentAudioSource = GetComponent<AudioSource>();
        scoreCard = GameObject.Find("score").GetComponent<Text>();
    }

    void Update()
    {
        scoreCard.text = score.ToString();

        if (Input.GetMouseButtonDown(0))
        {
                bulletFire();  
        }

        if (Input.GetMouseButtonDown(1))
        {
            reload = GameObject.FindGameObjectsWithTag("bullrt");

            foreach (GameObject destroyBullets in reload)
            {
                Destroy(destroyBullets);


            }
            bulletRange = 0;
            currentAudioSource.clip = gunReload;
            currentAudioSource.Play();
        }

    }
    
    void bulletFire()
    {

        if (bulletRange <= 10)
        {

            tempBullet = Instantiate(bulletObject, transform.position, transform.rotation);
            //object pooling

            Rigidbody rb = tempBullet.GetComponent<Rigidbody>();
            rb.AddForce(rb.transform.forward * 2200f);
            Debug.Log("status: " + bulletObject.tag);
            bulletRange++;
            currentAudioSource.clip = gunShot;
            currentAudioSource.Play();
        
        }
        else
        {    
            currentAudioSource.clip = emptyShot;
            currentAudioSource.Play();
        }
         
    }
  
}
