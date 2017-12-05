using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Globals
{
    class Session //Singleton class
    {

        private static Session instance;
        public Dictionary<Object, dynamic> session { get; set; }

        public Session() { 
        }

        public static Session getInstance() { 
            if (instance == null) {
                instance = new Session();
            }

            return instance;
        }

        public void setSessionParams(int id, string identification, string userName, string name, string pass) { 
            session = new Dictionary<object,dynamic>();
            session["id"] = id;
            session["identification"] = identification;
            session["username"] = userName;
            session["name"] = name;
            session["password"] = pass;
        }

        public void destroySession() { 
            session.Clear();
            session = null;
        }

    }
}
