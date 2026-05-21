using System.Collections.Generic;

namespace AetherArk.Aether.Core.Entity
{
    public class EntityManager
    {
        private HashSet<EntityUID> m_entities;
        private int lastUID = 0;

        public EntityManager() {
            m_entities = new HashSet<EntityUID>();
        }

        public EntityUID generateUID(Entity owner) {
            lastUID++;
            return new EntityUID(lastUID, owner);
        }

        public bool registerEntity(Entity entity) {
            return m_entities.Add(entity.uid);
        }
    }
}