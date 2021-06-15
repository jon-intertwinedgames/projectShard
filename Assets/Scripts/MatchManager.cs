using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangePhases());
    }

    private IEnumerator ChangePhases()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.5f);
            Phase.GoToNextPhase<GameplayStage.GameplayPhases>();
        }
    }
}
