namespace DesignPatterns.Template.Game
{
    internal abstract class GameAi
    {
        private List<Structure> _builtStructures;
        private const int MapCenter = 5;

        public GameAi()
        {
            _builtStructures = new List<Structure>();
        }

        public void TakeTurn()
        {
            CollectResources();
            BuildStructures();
            BuildUnits();
            Attack();
        }

        protected abstract void BuildStructures();
        protected abstract void BuildUnits();
        protected abstract void SendScouts(int position);
        protected abstract void SendWarriors(int position);

        protected void CollectResources()
        {
            foreach (var structure in _builtStructures)
            {
                structure.Collect();
            }
        }

        protected void Attack()
        {
            int? enemyPos = GetClosestEnemy();
#if DEBUG
            SendScouts(MapCenter);
            SendWarriors((int)enemyPos);
#else
            if (enemyPos == null) SendScouts(MapCenter);
            else SendWarriors((int)enemyPos);
#endif
        }

        private int GetClosestEnemy()
        {
            return 2;
        }
    }
}
