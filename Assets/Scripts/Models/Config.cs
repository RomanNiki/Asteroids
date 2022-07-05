namespace Models
{
    public static class Config
    {
        public static class Enemies
        {
            public const float UfoSpeed = 0.075f;
            public const float AsteroidSpeed = 0.075f;
        }
        
        public static class Bullets
        {
            public const float LaserCooldown = 3f;
            public const float DefaultBulletSpeed = 0.6f;
            public const float DefaultBulletLifeTime = 10f;
            public const float LaserBulletLifeTime = 0.5f;
            public const int LaserBulletCount = 10;
        }
     
        public static class Ship
        {
            public const float UnitsPerSecond = 0.001f;
            public const float MaxSpeed = 0.0015f;
            public const float SecondsToStop = 1f;
            public const float DegreesPerSecond = 180;
        }
    }
}