﻿using Livrable_AppliGraphique.Model;
using Livrable_AppliGraphique.Save_Window;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Livrable_AppliGraphique
{
    public sealed class Controller : IController
    {
        private Save save;
        private static Controller instance = null;
        public string softwareSocietyName;
        public string Extention;
        // Semaphore -> Limit the number of Thread

        public Controller()
        {
        }

        // Function call to update
        public void updateSave(string dirOrFile, string name, string source, string destination)
        {
            Save save = new Save(dirOrFile, name, source, destination);
            save.Extension = Extention;
            save.EnterpriseSoftwareRunning(softwareSocietyName);
            save.fileSave();
        }
    }
}