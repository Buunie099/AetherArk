using AetherArk.Aether.Core;
using AetherArk.Aether.Core.Collections;

namespace AetherArk.Aether.Core.Entity
{
    public class Entity
    {
        private EntityManager _entity = ManagerSystem.getInstance().entity;

        // private HashMap<> m_components;

        public EntityUID uid;

        public Entity()
        {
            // m_components = new HashMap<>();

            uid = _entity.generateUID(this);

            _entity.registerEntity(this);
        }
    }
}