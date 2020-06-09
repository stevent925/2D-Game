using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selector_Script : MonoBehaviour
{

	public GameObject Male;
	public GameObject Female;

	private Vector3 CharacterPosition;
	private Vector3 OffScreen;

	private int CharacterInt = 1;

	private SpriteRenderer MaleRenderer, FemaleRenderer;

	private void Awake()
	{
		CharacterPosition = Male.transform.position;
		OffScreen = Female.transform.position;

		MaleRenderer = Male.GetComponent<SpriteRenderer>();
		FemaleRenderer = Female.GetComponent<SpriteRenderer>();
	}

	public void MaleCharacter()
	{
		switch(CharacterInt)
		{
			case 1:
				break;
			case 2:
				break;
			default:
				break;
		}

	}

	public void FemaleCharacter()
	{
		switch (CharacterInt)
		{
			case 1:
				MaleRenderer.enabled = false;
				Male.transform.position = OffScreen;
				Female.transform.position = CharacterPosition;
				FemaleRenderer.enabled = true;
				CharacterInt++;
				break;
			case 2:
				FemaleRenderer.enabled = false;
				Female.transform.position = OffScreen;
				Male.transform.position = CharacterPosition;
				MaleRenderer.enabled = true;
				CharacterInt++;
				ResetInt();
				break;
			default:
				break;
		}
	}

	private void ResetInt()
	{
		if(CharacterInt >= 2)
		{
			CharacterInt = 1;
		}
	}

    public void backToMainMenu()
    {

        SceneManager.LoadScene(0);

    }

}
