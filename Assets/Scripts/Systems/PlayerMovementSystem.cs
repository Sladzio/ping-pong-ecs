using System.Collections;
using System.Collections.Generic;
using Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovementSystem : ComponentSystem
{
    private struct Group
    {
        public Transform Transform;
        public Speed Speed;
        public PlayerInput Input;
    }
    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Group>())
        {
            var position = entity.Transform.position;
            var rotation = entity.Transform.rotation;
            position.y += entity.Speed.Value * entity.Input.Vertical * Time.deltaTime;
            entity.Transform.position = position;
            entity.Transform.rotation = rotation;
        }
    }
}