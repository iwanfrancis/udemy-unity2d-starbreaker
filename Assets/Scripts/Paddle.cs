using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration paramaters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1.17f;
    [SerializeField] float maxX = 15f;

    // Cached references
    private Ball ball;
    private GameSession gameSession;

    // Start is called before the first frame update
    void Start() {
        ball = FindObjectOfType<Ball>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update() {
        Vector2 paddlePos = new Vector2(transform.position.y, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(),minX,maxX);
        transform.position = paddlePos;
    }

    private float GetXPos() {
        if (gameSession.IsAutoPlayEnabled()) {
            return ball.transform.position.x;
        } else {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
