using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Tarefas.Class
{
        internal class DataBase
        {
            public string dbName;
            public string Server;
            public string user;
            public string password;
            public string connectionRow;

            public string ConnectionnMake() 
            {
                this.connectionRow = $"Server={this.Server};Database={this.dbName};Uid={this.user};Pwd={this.password}";    
                return connectionRow;
            }
        }
    }
