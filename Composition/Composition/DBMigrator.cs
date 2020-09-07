namespace Composition
{
    public class DBMigrator
    {
        private readonly Logger logger;

        public DBMigrator(Logger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.Log("We are Find Application");
        }
    }
}
