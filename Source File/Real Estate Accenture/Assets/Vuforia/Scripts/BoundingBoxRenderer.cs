
using UnityEngine;
using Vuforia;


public class BoundingBoxRenderer : MonoBehaviour
{
    #region PRIVATE_MEMBERS

    private Material mLineMaterial = null;

    #endregion // PRIVATE_MEMBERS
    


    private void OnRenderObject()
    {
        GL.PushMatrix();
        GL.MultMatrix(transform.localToWorldMatrix);

        if (mLineMaterial == null)
        {
            
            var tempObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var cubeRenderer = tempObj.GetComponent<MeshRenderer>();
            
            mLineMaterial = new Material(cubeRenderer.material);
            mLineMaterial.color = Color.white;
            
            Destroy(tempObj);
        }

        mLineMaterial.SetPass(0);
        mLineMaterial.color = Color.white;
        
        GL.Begin(GL.LINES);

        // Bottom XZ quad
        GL.Vertex3(-0.5f, -0.5f, -0.5f);
        GL.Vertex3( 0.5f, -0.5f, -0.5f);

        GL.Vertex3(0.5f, -0.5f, -0.5f);
        GL.Vertex3(0.5f, -0.5f,  0.5f);

        GL.Vertex3( 0.5f, -0.5f, 0.5f);
        GL.Vertex3(-0.5f, -0.5f, 0.5f);

        GL.Vertex3(-0.5f, -0.5f, 0.5f);
        GL.Vertex3(-0.5f, -0.5f, -0.5f);

        // Top XZ quad
        GL.Vertex3(-0.5f, 0.5f, -0.5f);
        GL.Vertex3(0.5f,  0.5f, -0.5f);

        GL.Vertex3(0.5f,  0.5f, -0.5f);
        GL.Vertex3(0.5f,  0.5f, 0.5f);

        GL.Vertex3(0.5f,  0.5f, 0.5f);
        GL.Vertex3(-0.5f, 0.5f, 0.5f);

        GL.Vertex3(-0.5f, 0.5f, 0.5f);
        GL.Vertex3(-0.5f, 0.5f, -0.5f);

        // Side lines
        GL.Vertex3(-0.5f, -0.5f, -0.5f);
        GL.Vertex3(-0.5f,  0.5f, -0.5f);

        GL.Vertex3(0.5f, -0.5f, -0.5f);
        GL.Vertex3(0.5f,  0.5f, -0.5f);

        GL.Vertex3(0.5f, -0.5f, 0.5f);
        GL.Vertex3(0.5f,  0.5f, 0.5f);

        GL.Vertex3(-0.5f, -0.5f, 0.5f);
        GL.Vertex3(-0.5f,  0.5f, 0.5f);

        GL.End();

        GL.PopMatrix();
    }
}
