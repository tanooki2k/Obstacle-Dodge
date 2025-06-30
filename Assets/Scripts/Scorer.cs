using UnityEngine;

public class Scorer : MonoBehaviour
{
   private int _hits;

   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.tag != "Hit")
      {
         _hits++;
         Debug.Log($"You've bumped into a thing this many times: {_hits}");
      }
   }
}
