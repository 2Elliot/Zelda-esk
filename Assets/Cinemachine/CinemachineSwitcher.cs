using UnityEngine;

public class CinemachineSwitcher : MonoBehaviour
{

	public Animator animator;
	public Animator textAnimator;

	public string targetRoom;
	public bool roomText;
	public bool repeateRoomText;

	private bool hasEnteredRoom;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "PlayerSwitchRoomTrigger")
		{
			animator.Play(targetRoom);

			if (roomText)
			{
				showRoomText(targetRoom);
			}
		}
	}

	public void showRoomText(string targetRoom)
	{
		if (!repeateRoomText && !hasEnteredRoom)
		{
			textAnimator.Play(targetRoom);
			hasEnteredRoom = true;
		} else if (repeateRoomText)
		{
			textAnimator.Play(targetRoom);
		} else
		{
			return;
		}
		
	}

}
