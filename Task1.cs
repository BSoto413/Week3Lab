using UnityEngine;

public class Task1 : MonoBehaviour
{
    private float modWeight = 0.15f;
    private float readWeight = 0.3f;
    private float quizWeight = 0.15f;
    private float assignWeight = 0.3f;
    private float teachWeight = 0.1f;

    private int CalculateScore()
    {
        float weightSum = (modWeight * module) + (readWeight * reading) + (quizWeight * quiz) + (assignWeight * assignment) + (teachWeight * teach);
        int score = (int)Mathf.Clamp(weightSum, 1, 10);
        return score;
    }

    [SerializeField] private int module = 10;
    [SerializeField] private int reading = 8;
    [SerializeField] private int quiz = 6;
    [SerializeField] private int assignment = 4;
    [SerializeField] private int teach = 1;

    private void Start()
    {
        int score = CalculateScore();
        Debug.Log("Weighted Score: " + score);
    }
}