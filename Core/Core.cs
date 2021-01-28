using System.Security.Cryptography;

namespace Core
{
    public class CoreStore
    {
        private const DataProtectionScope Scope = DataProtectionScope.LocalMachine;
    }

    public class CoreCrypto
    {
        private static readonly CoreStore DefaultKeyStoreProvider = new CoreStore();
    }
}
