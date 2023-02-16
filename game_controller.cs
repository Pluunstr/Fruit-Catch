using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controller : MonoBehaviour
{
    public GameObject fruit_cherry;
    public GameObject fruit_orange;
    public GameObject fruit_grape;
    public GameObject junk_choc;
    public GameObject junk_lolly;
    public GameObject junk_pizza;
    public GameObject power_cola;
    public GameObject power_juice;
    public GameObject power_paste;

    public Transform wall_left;
    public Transform wall_right;

    private int rnd_food;

    private int player_lives;
    public static int player_score;

    private float timer_junk;
    private float timer_paste;
    void Start()
    {
        player_score = 0;
        player_lives = 3;
        timer_junk = 7.0f;
        timer_paste = 12.0f;
        InvokeRepeating("SpawnFruit", 2, 2);
        Invoke("SpawnJunk", timer_junk);
        Invoke("SpawnPaste", timer_paste);
    }
    void Update()
    {
        Debug.Log(player_lives);
    }
    void SpawnFruit()
    {
        int x = (int)Random.Range(wall_left.position.x + 4f, wall_right.position.x - 4f);
        int y = 10;
        rnd_food = Random.Range(1, 4);
        switch (rnd_food)
        {
            case 1:
                Instantiate(fruit_cherry, new Vector2(x, y), Quaternion.identity);
                break;
            case 2:
                Instantiate(fruit_grape, new Vector2(x, y), Quaternion.identity);
                break;
            case 3:
                Instantiate(fruit_orange, new Vector2(x, y), Quaternion.identity);
                break;
        }
    }
    void SpawnJunk()
    {
        int x = (int)Random.Range(wall_left.position.x + 4f, wall_right.position.x - 4f);
        int y = 10;
        rnd_food = Random.Range(1, 4);
        switch (rnd_food)
        {
            case 1:
                Instantiate(junk_choc, new Vector2(x, y), Quaternion.identity);
                break;
            case 2:
                Instantiate(junk_lolly, new Vector2(x, y), Quaternion.identity);
                break;
            case 3:
                Instantiate(junk_pizza, new Vector2(x, y), Quaternion.identity);
                break;
        }
        Invoke("SpawnJunk", timer_junk);
    }
    void SpawnPaste()
    {
        int x = (int)Random.Range(wall_left.position.x + 4f, wall_right.position.x - 4f);
        int y = 12;
        Instantiate(power_paste, new Vector2(x, y), Quaternion.identity);
        Invoke("SpawnPaste", timer_paste);
    }
    public void addPoints()
    {
        player_score += 10;
        if (timer_junk >= 1.5f)
        {
            timer_junk /= 1.1f;
        }
        if (player_score == 150)
        {
            Invoke("SpawnJunk", 1);
        }
    }
    public void subtractLife()
    {
        player_lives -= 1;
    }
    public void gainLife()
    {
        player_lives += 1;
        timer_paste += 5;
    }
}