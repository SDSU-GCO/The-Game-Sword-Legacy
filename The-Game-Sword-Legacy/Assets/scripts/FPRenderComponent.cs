using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPRenderNamespace
{

    [RequireComponent(typeof(MeshRenderer))]
    [ExecuteInEditMode]
    public class FPRenderComponent : MonoBehaviour {
        
        public MeshRenderer DefaultUnityMeshRenderer { get; private set; }

        private void OnEnable()
        {
            DefaultUnityMeshRenderer = GetComponent<MeshRenderer>();
            FPRenderPipelineAsset.ListOfRenderComponent.Add(this);
        }
        private void OnDisable()
        {
            FPRenderPipelineAsset.ListOfRenderComponent.Remove(this);
        }

    }

}
