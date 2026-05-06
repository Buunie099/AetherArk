namespace AetherArk.Aether.Core
{
    public class ManagerSystem
    {
        private static ManagerSystem instance = default;
        public EntityManager entity = default;

        private ManagerSystem()
        {
            entity = new EntityManager();
        }

        public static ManagerSystem getInstance()
        {
            if (instance == null)
            {
                instance = new ManagerSystem();
            }
        }
    }
}