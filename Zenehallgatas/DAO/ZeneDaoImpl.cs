using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenehallgatas.Model;

namespace Zenehallgatas.DAO
{
    internal class ZeneDaoImpl : IZeneDao
    {
        public bool addZene(Zene zene)
        {
            return true;
        }

        public List<Zene> getAllZeneList()
        {
            return new List<Zene> { new Zene(1, "Cím", "Valki", 2024, 1,1),
                                    new Zene(2,"Immigrant song","Led Zeppelin",2020,226,2),
                                    new Zene(3,"BACK2BACK","STRLGHT",2023,223,3),
                                    new Zene(4,"I Had Some Help","Post Malone",2024,321,5)};
        }

        public Zene getZene(int id)
        {
            return new Zene();
        }

        public bool modifyZene(Zene zene)
        {
            return true;
        }
    }
}
