using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace BAMTS.Internal.WebAPI.Client
{
    public abstract class WebAPIClient
    {
        public string RootPath { get; private set; }
        public string Protocol { get; private set; }
        public string MediaType { get; private set; }
        public string ServerName { get; private set; }
        public string ControllerName { get; private set; }
        public int PortNo { get; private set; }
        protected string URIBase 
        { 
            get 
            { 
                if(string.IsNullOrEmpty(this.RootPath))
                    return $"{this.Protocol}://{this.ServerName}:{this.PortNo}/{this.ControllerName}"; 
                else
                    return $"{this.Protocol}://{this.ServerName}:{this.PortNo}/{this.RootPath}/{this.ControllerName}";
            }
        }
        public WebAPIClient(string serverName, int portNo, string controllerName, string protocol = "http", string rootPath = "api", string mediaType = "application/json")
        {
            this.ServerName = serverName;
            this.PortNo = portNo;
            this.ControllerName = controllerName;
            this.Protocol = protocol;
            this.RootPath = rootPath;
            this.MediaType = mediaType;
        }
    }
}
