using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahmedmohamdytrainig
{
    internal static class Connections
    {
     public const string sqlConstr = """
    server=.;
    Database=AhmedMohamdyTraining;
    trusted_connection=true; 
    TrustServerCertificate=True;
    """;
    }
}
