using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorScript : MonoBehaviour
{
    public Animator CabAnim;
    public Animator FrankAnim;
    public Animator DrugStoreAnim;
    public SpriteRenderer DrugStoreRender;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(CabStop());
      StartCoroutine(CabGo());
      StartCoroutine(FrankWalk());
      StartCoroutine(FrankGetIn());
      StartCoroutine(DrugStoreOpen());
      StartCoroutine(DrugStoreClose());
      StartCoroutine(FrankGetOut());
    }

    IEnumerator CabStop()
    {
      yield return new WaitForSeconds(7f);
      CabAnim.SetBool("IsGoing", true);
    }

    IEnumerator CabGo()
    {
      yield return new WaitForSeconds(9.5f);
      CabAnim.SetBool("IsGoing", false);
    }

    IEnumerator FrankWalk()
    {
      yield return new WaitForSeconds(14.6f);
      FrankAnim.SetTrigger("Walk");
    }

    IEnumerator FrankGetIn()
    {
      yield return new WaitForSeconds(20.5f);
      FrankAnim.SetBool("GetIn", true);
    }

    IEnumerator DrugStoreOpen()
    {
      yield return new WaitForSeconds(22f);
      DrugStoreAnim.SetBool("DrugStoreOpen", true);
    }

    IEnumerator DrugStoreClose()
    {
      yield return new WaitForSeconds(23f);
      DrugStoreAnim.SetBool("DrugStoreOpen", false);
      DrugStoreRender.sortingOrder = 5;
    }

    IEnumerator FrankGetOut()
    {
      yield return new WaitForSeconds(45f);
      DrugStoreRender.sortingOrder = 3;
      FrankAnim.SetBool("GetIn", false);
      FrankAnim.SetTrigger("Walk");
      print("Test");
    }

}//class





















//space
