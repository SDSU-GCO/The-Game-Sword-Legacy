using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BreadSlicerRenderNamespace
{

    [RequireComponent(typeof(MeshRenderer))]
    [ExecuteInEditMode]
    public class BreadSlicerRenderComponent : MonoBehaviour {

        //private GameObject i;
        public MeshRenderer BreadSlicerMeshRenderer { get; private set; }
        //// Use this for initialization
        //void Start() {

        //}

        //// Update is called once per frame
        //void Update() {

        //}

        private void OnEnable()
        {
            BreadSlicerMeshRenderer = GetComponent<MeshRenderer>(); //?   
            BreadSlicerRenderPipelineAsset.ListOfRenderComponent.Add(this);
        }
        private void OnDisable()
        {
            BreadSlicerRenderPipelineAsset.ListOfRenderComponent.Remove(this);
        }

    }

}
