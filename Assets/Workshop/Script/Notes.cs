using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is just to store notes in editor for easy reference.
/// </summary>
public class Notes : MonoBehaviour
{
	[TextArea(40 , 14)]
	[SerializeField]
	string  note;
    
}
