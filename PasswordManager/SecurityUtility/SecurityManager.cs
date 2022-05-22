using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SecurityUtility
{
    public class SecurityManager
    {
        // CONFIG PARAMETERS
        private readonly int    DERIVE_KEY_LEN      = 256;
        private readonly int    DERIVE_ITERATIONS   = 9872;
        private readonly byte[] DERIVAE_SALT        = new byte[] { 1, 2, 23, 234, 37, 48, 134, 63, 248, 4 };

        private SymmetricAlgorithm masterPasswordSA;
        private byte[] encryptedMasterPassword;

        public SecurityManager(string masterPassword)
        {
            this.masterPasswordSA = new AesManaged();

            encryptedMasterPassword = SymmetricalEncryptData(masterPasswordSA, masterPassword);
        }

        public byte[] EncryptData(string inputData)
        {
            SymmetricAlgorithm currentAES;
            currentAES = Derive_Key_From_Password_rfc2898(SymmetricalDecryptData(masterPasswordSA, encryptedMasterPassword));

            return SymmetricalEncryptData(currentAES, inputData);
        }

        public string DecryptData(byte []encrypteInputData)
        {
            SymmetricAlgorithm currentAES;
            currentAES = Derive_Key_From_Password_rfc2898(SymmetricalDecryptData(masterPasswordSA, encryptedMasterPassword));
            
            return SymmetricalDecryptData(currentAES, encrypteInputData);
        }

        public string Encode_to_SHA256_string(string inputString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding encodingType = Encoding.ASCII;
                Byte[] hashedData = hash.ComputeHash(encodingType.GetBytes(inputString));

                foreach (Byte _byte in hashedData)
                    stringBuilder.Append(_byte.ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        private byte[] SymmetricalEncryptData(SymmetricAlgorithm aesAlgorithm, string inputData)
        {
            ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(cs))
                    {
                        writer.Write(inputData);
                    }
                }
                return (ms.ToArray());
            }
        }

        private string SymmetricalDecryptData(SymmetricAlgorithm aesAlgorithm, byte[] inputEncryptedData)
        {
            ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            using (MemoryStream ms = new MemoryStream(inputEncryptedData))
            {
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(cs))
                    {
                        return (reader.ReadToEnd());
                    }
                }
            }
        }

        private SymmetricAlgorithm Derive_Key_From_Password_rfc2898(string password)
        {
            byte[] salt = new byte[] { 1, 2, 23, 234, 37, 48, 134, 63, 248, 4 };
            const int Iterations = 9872;

            SymmetricAlgorithm currentAES = new AesManaged();
            
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                if (!currentAES.ValidKeySize(DERIVE_KEY_LEN))
                    throw new InvalidOperationException("Invalid size key");

                currentAES.Key = rfc2898DeriveBytes.GetBytes(DERIVE_KEY_LEN / 8);
                currentAES.IV = rfc2898DeriveBytes.GetBytes(currentAES.BlockSize / 8);
                return currentAES;
            }
        }

        private string ComputeKeyHash()
        {
            SymmetricAlgorithm currentAES = Derive_Key_From_Password_rfc2898(SymmetricalDecryptData(masterPasswordSA, encryptedMasterPassword));
            return Encode_to_SHA256_string(BitConverter.ToString(currentAES.Key).Replace("-", ""));
        }


        public bool ValidatePasswordHash(string hash)
        {
            return (hash == ComputeKeyHash());
        }
    }
}
