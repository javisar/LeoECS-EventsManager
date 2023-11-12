using Leopotam.EcsLite;

namespace RogueProto.Scripts.Engine.ECS
{
    public class EventBusManager : IEventBusManager
    {
        private EcsWorld _ecsWorld;
        private int _ecsWorldEntity;

        public EventBusManager(EcsWorld _ecsWorld, int _ecsWorldEntity)
        {
            this._ecsWorld = _ecsWorld;
            this._ecsWorldEntity = _ecsWorldEntity;
        }

        public void SendEvent<T>() where T : struct
        {
            EcsPool<T> poolT = _ecsWorld.GetPool<T>();
            poolT.Add(_ecsWorldEntity);
        }

        public void SendEvent<T>(T obj) where T : struct
        {
            EcsPool<T> poolT = _ecsWorld.GetPool<T>();
            ref T c1 = ref poolT.Add(_ecsWorldEntity);
            c1 = obj;
        }

        public void SendEvent<T>(int entity, T obj) where T : struct
        {
            EcsPool<T> poolT = _ecsWorld.GetPool<T>();
            ref T c1 = ref poolT.Add(entity);
            c1 = obj;
        }
    }
}