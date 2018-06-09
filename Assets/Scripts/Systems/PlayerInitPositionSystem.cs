using Components;
using Enums;
using Unity.Entities;
using UnityEngine;

namespace Systems
{
    public class PlayerInitPositionSystem : ComponentSystem
    {
        private struct Group
        {
            public InitPosition InitPosition;
            public Transform Transform;
        }

        protected override void OnStartRunning()
        {
            foreach (var entity in GetEntities<Group>())
            {
                switch (entity.InitPosition.PlayerType)
                {
                    case PlayerType.Player:
                        break;
                    case PlayerType.Enemy:
                        break;
                }
            }
        }

        protected override void OnUpdate()
        {
        }
    }
}