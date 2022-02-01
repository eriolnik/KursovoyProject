using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        public CarController car; //автомобильный контроллер необходимо перетащить в инспектор

        private Renderer m_Renderer;


        private void Start()
        {
            m_Renderer = GetComponent<Renderer>();
        }


        private void Update()
        {
            // когда автомобиль тормозит выключить визуализатор в юнити нужно
            m_Renderer.enabled = car.BrakeInput > 0f;
        }
    }
}
