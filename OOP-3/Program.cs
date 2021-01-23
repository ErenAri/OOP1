using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager personelKrediManager = new PersonelKrediManager();
            IKrediManager autoKrediManager = new AutoKrediManager();
            IKrediManager propertyKrediManager = new PropertyKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(autoKrediManager,new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {personelKrediManager,autoKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
