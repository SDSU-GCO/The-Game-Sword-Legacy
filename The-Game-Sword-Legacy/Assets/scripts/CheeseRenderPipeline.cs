using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace CheeseRenderNamespace
{
	//this is the render pipeline
    public class CheeseRenderPipeline : RenderPipeline
    {
		//this holds a reference to an instance of a pipeline asset
        private CheesePipelineAsset assetReference;

		//Consturctor that gets a reference to an asset passed in.
        public CheeseRenderPipeline(CheesePipelineAsset cheesePipelineAsset)
        {
			//store a pointer to the asset
            assetReference = cheesePipelineAsset; //shouldn't be null
        }

		//draws to screen?
        public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
        {
			//call render, for a camera?
            base.Render(renderContext, cameras);
        }

    }
}
