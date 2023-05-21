﻿#if UNITY_EDITOR
using System;
using UnityEditor;

namespace CustomAttribute.EditorTools
{
	[Serializable]
	public class EditorPrefsType
	{
		public string Key { get; protected set; }
		
		public bool IsSet => EditorPrefs.HasKey(Key);

		public void Delete() => EditorPrefs.DeleteKey(Key);
	}
}
#endif