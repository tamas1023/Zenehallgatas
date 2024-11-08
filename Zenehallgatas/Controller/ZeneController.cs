using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenehallgatas.DAO;
using Zenehallgatas.Model;

namespace Zenehallgatas.Controller
{
    internal class ZeneController
    {
        private static ZeneDaoImpl dao;
        private static ZeneController instance;

        private ZeneController() {
            dao = new ZeneDaoImpl();   
        }

        public static ZeneController getInstance()
        {
            if (instance == null)
            {
                instance = new ZeneController();
            }
            return instance;
        }

        public bool addZene(Zene zene)
        {
            return dao.addZene(zene);
        }

        public List<Zene> getAllZeneList()
        {
            return dao.getAllZeneList();
        }

        public Zene getZene(int id)
        {
            return dao.getZene(id);
        }

        public bool modifyZene(Zene zene)
        {
            return dao.modifyZene(zene);
        }
    }
}
