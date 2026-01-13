using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;


public class collision : MonoBehaviour
{
    public int scorePerTree = 10;
    private int treesDestroyed = 0;
    public ParticleSystem particle;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit tree: " + collision.transform.root.name);
        if (collision.gameObject.CompareTag("Tree"))
        {
            treesDestroyed++;
            Destroy(collision.gameObject);
            particle.Play();
        }

        //TreeMarker tree = collision.transform.GetComponentInParent<TreeMarker>();

        //if (tree != null)
        //{
        //    treesDestroyed++;
        //    Destroy(tree.gameObject);
        //}
    }

    public int GetScore()
    {
        return treesDestroyed * scorePerTree;
    }
}
