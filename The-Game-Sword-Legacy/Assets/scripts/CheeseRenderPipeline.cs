using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace CheeseRenderNamespace
{
    public class CheeseRenderPipeline : RenderPipeline
    {
        private CheesePipelineAsset assetReference;
        public CheeseRenderPipeline(CheesePipelineAsset cheesePipelineAsset)
        {
            assetReference = cheesePipelineAsset; //shouldn't be null
        }

        public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
        {
            base.Render(renderContext, cameras);
        }

    }
}
