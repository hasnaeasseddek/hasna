using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Data.AppMetaData
{
    public class Router
    {
        public const string root = "Api";
        public const string version = "V1";
        public const string Role = root+"/"+version+"/";
        

        public static class OffreRouting
        {
            public const string Prefix =Role+"Offre";
            public const string List = Prefix+"/List";
            public const string LatestOffre = Prefix + "/LatestOffre";
            public const string Paginated = Prefix+ "/Paginated";
            public const string GetByID = Prefix+"/{id}";
            public const string Create = Prefix+"/Create";
            public const string Edit = Prefix+ "/Edit";
            public const string Delete = Prefix+ "/{id}";
        }
    }
}
