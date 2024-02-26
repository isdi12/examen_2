using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Firework : MonoBehaviour
{
    public float force, minTimeToExplode, maxTimeToExplode;
    public int minFireworks, maxFireworks;
    public GameObject fireworkPrefab;
    public int maxExplosions = 3;

    private Rigidbody2D _rb;
    private SpriteRenderer _rend;
    private int _count = 0;
    private Vector2 _dir = Vector2.up;
    private float currentTime, timeToExplode;
    private Color colors;
    public int FireWorks = 1;
    private int totalFireWorks;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rend = GetComponent<SpriteRenderer>();
        totalFireWorks = GameManager.instance.GetFireWorks(); // para que se consigan los puntos 
        totalFireWorks = FireWorks + totalFireWorks; // para que se vayan sumando 
        GameManager.instance.SetFireWorks(totalFireWorks);
        speed = 2;
        timeToExplode = Random.Range(minTimeToExplode, maxTimeToExplode);
       _rend.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 1f);
    }

        // Update is called once per frame
        void FixedUpdate()
        {
          _rb.velocity = _dir * speed;
        currentTime += Time.fixedDeltaTime;
         if(currentTime> timeToExplode)
        {
            Destroy(gameObject);
        }
        
        }
 }

