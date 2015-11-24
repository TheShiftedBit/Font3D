using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(MeshRenderer))]
[RequireComponent (typeof(TextMesh))]
#if UNITY_EDITOR
[ExecuteInEditMode]
#endif
public class Font3D : MonoBehaviour {
	Renderer rend;
	TextMesh mesh;
	Shader shader;
	[SerializeField]
	Material matInstance;

	void Update() {
		if(rend == null) {
			rend = GetComponent<Renderer>();
			if(rend == null) {
				rend = gameObject.AddComponent<MeshRenderer>();
			}
		}
		if(mesh == null) {
			mesh = GetComponent<TextMesh>();
			if(mesh == null) {
				mesh = gameObject.AddComponent<TextMesh>();
			}
		}

		if(matInstance == null) {
			if(shader == null) {
				shader = Shader.Find("3D Text");
			}
			matInstance = new Material(shader);
			matInstance.hideFlags = HideFlags.HideInInspector;
		}

		if(rend.sharedMaterial != matInstance) {
			rend.sharedMaterial = matInstance;
		}

		rend.sharedMaterial.color = mesh.color;
		rend.sharedMaterial.mainTexture = mesh.font.material.mainTexture;
	}

	void OnDestroy() {
		DestroyImmediate(matInstance);
	}
}
