using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{

    public GameObject bonusAngkor;
    private Collider2D col;
    private float normalSpeed = 5f;
    public float speed = 2f;

    private void Start()
    {
        //set collider menjadi trigger
    }
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Single);
        }
    }

    public void setBonus(GameObject bonus)
    {
        BarierBonus barierBonus = bonus.GetComponent<BarierBonus>();
        barierBonus.setAngkor(bonusAngkor, 10f);
        Instantiate(bonus, bonusAngkor.transform.position, bonusAngkor.transform.rotation);
    }

}
