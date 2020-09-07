using System;

namespace InterfaceDemo
{
    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }
        public void Migrator()
        {
            logger.LogInfo("Migrating Started at "+ DateTime.Now);
            logger.LogInfo("Migrating Finished at "+ DateTime.Now);
            Console.WriteLine();
            logger.LogError("Migrating Started at " + DateTime.Now);
            logger.LogError("Migrating Finished at " + DateTime.Now);
        }
    }
}
