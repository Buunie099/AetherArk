namespace AetherArk.Aether.Core.Entity
{
    public class EntityUID
    {
        private int m_value = -1;
        public Entity Owner;

        public EntityUID(int value, Entity owner) {
            m_value = value;
            Owner = owner;
        }
    }
}