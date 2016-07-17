using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Singleton.RealWorld
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        private static object syncLock = new object();


        protected LoadBalancer()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");

        }

        public static LoadBalancer GetLoadBalancer() {
            if (_instance == null)
            {
                lock (syncLock) {
                    _instance = new LoadBalancer();
                }
            }

            return _instance;
        }

        public string Server
        {
            get {
                int random = _random.Next(_servers.Count);
                return _servers[random].ToString();
            }
        }
        
    }
}
