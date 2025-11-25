using Scripts.Domain.Gameplay.Models;
using UnityEngine;
using VContainer;

namespace Scripts.Presentation
{
    [RequireComponent(typeof(MeshRenderer))]
    public class MapView : MonoBehaviour
    {
        [Inject] private Map _map;
        private MeshRenderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<MeshRenderer>();
            _renderer.transform.localScale = new Vector3(_map.SizeX, 0, _map.SizeY);
            _renderer.material.mainTextureScale = new Vector2(_map.SizeX, _map.SizeY);
        }
    }
}