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
            throw new NotImplementedException();
        }

        public List<Zene> getAllZeneList()
        {
            return new List<Zene> { new Zene(1, "Cím", "Valki", 2024, 1) };
        }

        public Zene getZene(int id)
        {
            throw new NotImplementedException();
        }

        public bool modifyZene(Zene zene)
        {
            throw new NotImplementedException();
        }
    }
}
