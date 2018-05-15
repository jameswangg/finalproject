using FinalProject.Repository;

namespace FinalProject.Repository
{
    public class DatabaseAccessor
    {
        private static readonly ClassesDbEntities entities;

        static DatabaseAccessor()
        {
            entities = new ClassesDbEntities();
            entities.Database.Connection.Open();
        }

        public static ClassesDbEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}