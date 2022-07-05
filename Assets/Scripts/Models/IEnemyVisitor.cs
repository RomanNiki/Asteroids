using Models.Enemies;

namespace Models
{
    public interface IEnemyVisitor
    {
        void Visit(Enemy enemy);
        void Visit(Asteroid asteroid);
        void Visit(Ufo ufo);
        void Visit(PartOfAsteroid nlo);
    }
}