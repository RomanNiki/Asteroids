using Models.Enemies;

namespace Models
{
    public class Score
    {
        private readonly EnemyVisitor _enemyVisitor;

        public Score()
        {
            _enemyVisitor = new EnemyVisitor();
        }
        
        public int Value => _enemyVisitor.AccumulatedScore;
        
        public void OnKill(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);
        }
        
        private class EnemyVisitor : IEnemyVisitor
        {
            public int AccumulatedScore { get; private set; }

            public void Visit(Asteroid asteroid)
            {
                AccumulatedScore += 10;
            }

            public void Visit(Ufo ufo)
            {
                AccumulatedScore += 20;
            }

            public void Visit(PartOfAsteroid nlo)
            {
                AccumulatedScore += 5;
            }

            public void Visit(Enemy enemy)
            {
                Visit((dynamic)enemy);
            }
        }
    }
    
}
