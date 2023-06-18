// https://github.com/ShadowIgnition/Unity-ScriptableObjectFactoryWindow
using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

/// <summary>
/// Editor window for creating ScriptableObjects.
/// </summary>
public class ScriptableObjectFactoryWindow : EditorWindow
{
	/// <summary>
	/// Opens the ScriptableObject Factory window from the Unity Editor menu.
	/// </summary>
	[MenuItem("Tools/" + WINDOW_NAME)]
	static void OpenWindow()
	{
		ScriptableObjectFactoryWindow window = GetWindow<ScriptableObjectFactoryWindow>();
		window.titleContent = new GUIContent(WINDOW_NAME);
		window.Show();
	}

	/// <summary>
	/// Draws the GUI content of the editor window.
	/// </summary>
	void OnGUI()
	{
		m_ScrollPosition = EditorGUILayout.BeginScrollView(m_ScrollPosition);

		// Display a button for each ScriptableObject type
		foreach (Type type in m_ScriptableObjectTypes)
		{
			if (GUILayout.Button(type.Name))
			{
				CreateScriptableObjectInstance(type);
			}
		}

		EditorGUILayout.EndScrollView();
	}

	/// <summary>
	/// Creates an instance of the specified ScriptableObject type and saves it as an asset.
	/// </summary>
	/// <param name="type">The type of ScriptableObject to create.</param>
	void CreateScriptableObjectInstance(Type type)
	{
		ScriptableObject asset = ScriptableObject.CreateInstance(type);

		string assetPath = AssetDatabase.GenerateUniqueAssetPath("Assets/New" + type.Name + ".asset");
		AssetDatabase.CreateAsset(asset, assetPath);
		AssetDatabase.SaveAssets();

		Selection.activeObject = asset;
	}

	const string WINDOW_NAME = "ScriptableObject Factory"; // Name of the window

	// List of ScriptableObject types
	// Add your ScriptableObject types here
	Type[] m_ScriptableObjectTypes = new Type[]
	{
		typeof(ScriptableObject),
		typeof(ScriptableObject),
		typeof(ScriptableObject),
	};

	Vector2 m_ScrollPosition; // Scroll position for the editor window
}
#endif
