using UnityEngine;
using System.Collections;

public class ParticleSorter : MonoBehaviour {

    public string Layer = "Particles";
    // Use this for initialization
    void Start()
    {
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = Layer;
    }
}