using Newtonsoft.Json.Linq;
using System;

namespace Kudu.Core.Functions
{
    public interface IKeyJsonOps<T>
    {
        int RequireKeyCount();
        
        // key generation is based on run time
        string GenerateKeyUglyJson(Tuple<string,string>[] keyPairs, string functionRt, out string unencryptedKey);
        
        // read existing key file based on the content format, not the run time version
        string GetKeyInString(string json, out bool isEncrypted);

        T GenerateKeyObject(string functionKey, string functionName);
    }
}
