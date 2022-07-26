using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float duration, currentTime;
    public void Start()
    {
        currentTime = duration;
        StartCoroutine(timeIEn());
    }
    public GameObject hiteffect;
    public int damag = 80;
    /*  private void OnCollisionEnter2D(Collision2D collision)
      {
          Destroy(gameObject, 10f);

          Enemy enemy = hit
      }
      */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*Enemy enemy = collision.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.takedamage(damag);
            enemy.setactive(false);
        }
        if(collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        */

        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.SetActive(false);
        }
    }
    IEnumerator timeIEn()
    {
        while (currentTime >= 0)
        {
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        destroonject();
    }

    void destroonject()
    {
        gameObject.SetActive(false);
    }
}
