
using TMPro;
using Unity.Properties;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] brickPref;

    public float spawnRate;

    bool gameStarted = false;
    public DodgerAttributes attributes;


    public GameObject tapText;
    public TextMeshProUGUI scoreText;
   

    Vector2 screenPos;

    void Start()
    {
        attributes.SetTheScore(0);
        UpdateText(attributes.GetTheScore());

    
    }


    // Update is called once per frame
    void Update()
    {
        
        if (transform.GetComponent<InputSys>().IsPressing(out screenPos) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            tapText.SetActive(false);
        }
    }


    void StartSpawning()
    {
        InvokeRepeating("SpawnBrick",0.5f, spawnRate);
    }

    


    void SpawnBrick ()
    {
        Camera cam = Camera.main;

        float randomX = Random.Range(0f, 1f);
        int randomY = Random.Range(0, brickPref.Length);

        Vector3 viewportPos = new Vector3(randomX, 1f, 0f);

        Vector3 worldPos = cam.ViewportToWorldPoint(viewportPos);

        worldPos.y += 1f;
        worldPos.z = 0f;

        Instantiate(brickPref[randomY], worldPos, Quaternion.identity);

        attributes.SetTheScore(attributes.GetTheScore() + 1);


        UpdateText(attributes.GetTheScore());
    }


    void UpdateText(int score)
    {

        scoreText.text = score.ToString();
    }
}
