using AllProjectOfEnginHocaCamp.Abstract;
using AllProjectOfEnginHocaCamp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllProjectOfEnginHocaCamp.Concrete
{
    class GamesManager : IGamesService
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.Name + " has added to your basket.");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.Name + " has removed from your basket.");
        }

     
    }
}
