using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    // Config paramaters
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockSparklesVFX;
    [SerializeField] int maxHits;

     // Cached reference
    Level level;
    GameSession gameSession;

    // State Variables
    [SerializeField] int timesHit; //TODO remove serialize

    private void Start() {
        CountBreakableBlocks();
        gameSession = FindObjectOfType<GameSession>();
    }

    private void CountBreakableBlocks(){
        if (tag == "Breakable") {
            level = FindObjectOfType<Level>();
            level.CountBlocks();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (tag == "Breakable") {
            HandleHit();
        }
    }

    private void HandleHit() {
        timesHit++;
        if (timesHit >= maxHits)
        {
            DestroyBlock();
        }
    }

    private void DestroyBlock() {
        gameSession.AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.BlockDestroyed();
        TriggerSparklesVFX();
        Destroy(gameObject);
    }

    private void TriggerSparklesVFX() {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 2f);
    }
    
}
