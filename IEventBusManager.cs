namespace RogueProto.Scripts.Engine.ECS
{
    public interface IEventBusManager
    {
        public void SendEvent<T>() where T : struct;
        public void SendEvent<T>(T obj) where T : struct;
        public void SendEvent<T>(int entity, T obj) where T : struct;
    }

}
