using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class EnableAnimations : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    public GameObject animationClips;
    public GameObject animationClips1;
    public int flag = 0;

    void Start()
    {
        animationClips.SetActive(false);
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
     void Update()
    {
        if(animationClips1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1 && flag==1 && !animationClips1.GetComponent<Animator>().IsInTransition(0))
        {
            animationClips.SetActive(true);
            animationClips.GetComponent<Animator>().Play("KeysAnim");
        }
    }
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
    {

        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            
            Debug.Log("yes");
            animationClips1.GetComponent<Animator>().Play("NameAnim");
            flag = 1;
        }
    }
}*/


