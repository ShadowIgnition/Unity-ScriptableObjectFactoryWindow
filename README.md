# ScriptableObject Factory Window README

`ScriptableObject Factory Window` is an editor window for creating ScriptableObjects in Unity. It provides a convenient interface within the Unity Editor for creating instances of ScriptableObjects.

![ScriptableObject Factory Window](preview.png)

## Usage

To use the `ScriptableObject Factory Window`, follow these steps:

1. Open the Unity Editor.
2. In the Unity Editor menu, navigate to "Tools" and select "ScriptableObject Factory".
3. The `ScriptableObject Factory Window` will open, displaying a list of available ScriptableObject types.
4. Click on the desired ScriptableObject type to create an instance of it.

## Customization

The `ScriptableObject Factory Window` can be customized according to your needs. Here are some options for customization:

- Add or remove ScriptableObject types: Open the `ScriptableObjectFactoryWindow.cs` script and modify the `m_ScriptableObjectTypes` array to include the desired ScriptableObject types.

```csharp
public class ScriptableObjectFactoryWindow : EditorWindow
{
	// List of ScriptableObject types
	// Add your ScriptableObject types here
	Type[] m_ScriptableObjectTypes = new Type[]
	{
		typeof(YourScriptableObjectTypeHere1),
		typeof(YourScriptableObjectTypeHere2),
		typeof(YourScriptableObjectTypeHere3),
	};
 }
```

- Modify the window title: Open the `ScriptableObjectFactoryWindow.cs` script and change the value of the `WINDOW_NAME` constant to set a different window title.

## Notes

- **Recommended Location:** For best usage and organization, it is recommended to place the `ScriptableObjectFactoryWindow.cs` file in the `Assets/Editor` folder of your Unity project. For more information refer to the [Unity documentation on Special Folders](https://docs.unity3d.com/Manual/SpecialFolders.html).

- If you find the `I2Preview` attribute helpful, please consider giving it a star on the GitHub repository. Your support is greatly appreciated!

## License

The `ScriptableObject Factory Window` attribute is provided as-is under the terms of the MIT License. Feel free to modify and adapt it to suit your needs.
