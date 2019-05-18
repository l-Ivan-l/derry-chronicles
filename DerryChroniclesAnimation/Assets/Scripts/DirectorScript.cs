using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorScript : MonoBehaviour
{
    public Animator CabAnim;
    public Animator FrankAnim;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(CabStop());
      StartCoroutine(CabGo());
      StartCoroutine(FrankWalk());
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

}//class





















//space
