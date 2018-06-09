using Components;
using Unity.Entities;
using UnityEngine;

namespace Systems
{
    public class PlayerInputSystem : ComponentSystem
    {
        private struct Group
        {
            public PlayerInput Input;
        }

        protected override void OnStartRunning()
        {
            base.OnStartRunning();
            
        }

        protected override void OnUpdate()
        {
            foreach (var entity in GetEntities<Group>())
            {
                entity.Input.Vertical = Input.GetAxis("Vertical");
            }
        }
    }
}