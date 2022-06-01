using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI Scoretext;
    public TextMeshProUGUI GameoverText;
    public Button RestartButton;
    public GameObject TitleScreen;
    private int score;
    public bool gameActive;
    private float spawnrate = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    IEnumerator SpawnTarget()
    {
        while (gameActive)
        {
            yield return new WaitForSeconds(spawnrate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            
            if (gameObject.transform.position.y < -1)
            {
                Destroy(gameObject);
            }
        }
    }
    
    public void UpdateScore(int scoretoadd)
    {
        score = score+scoretoadd;
        Scoretext.text = "Score: " + score;
    }

    public void Gameover()
    {
        GameoverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
        gameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

     public void StartGame(int difficulty)
    {
        gameActive = true;
        spawnrate /= difficulty;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        TitleScreen.gameObject.SetActive(false);
    }
}
