using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SecurityUtility
{
    public class SecurityManager
    {

        // CONFIG PARAMETERS
        private int GENERATED_PASSWORD_LENGTH = 18;
        private const int SALT_SIZE = 24; // size in bytes
        private const int HASH_SIZE = 16; // size in bytes
        private const int ITERATIONS = 100000; // number of pbkdf2 iterations

        private static readonly byte[] CONSTANT_SALT = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        private SymmetricAlgorithm masterPasswordSA;
        private byte[] encryptedMasterPassword;

        public SecurityManager(string masterPassword)
        {
            this.masterPasswordSA = new AesManaged();

            encryptedMasterPassword = SymmetricalEncryptData(masterPasswordSA, masterPassword);
            // DecryptData(masterPasswordSA, encryptedMasterPassword);
        }

        public byte[] EncryptData(string inputData)
        {
            SymmetricAlgorithm currentAES = new AesManaged();
            //return Encode_to_PBKDF2_Byte_Hash(SymmetricalDecryptData(masterPasswordSA, encryptedMasterPassword));
            currentAES.Key = Encode_to_PBKDF2_Byte_Hash(SymmetricalDecryptData(masterPasswordSA, encryptedMasterPassword));
            return SymmetricalEncryptData(currentAES, inputData);
        }

        public string DecryptData(byte []encrypteInputData)
        {
            SymmetricAlgorithm currentAES = new AesManaged();
            currentAES.Key = Encode_to_PBKDF2_Byte_Hash(SymmetricalDecryptData(masterPasswordSA, encryptedMasterPassword));
            
            //return BitConverter.ToString(Encode_to_PBKDF2_Byte_Hash(SymmetricalDecryptData(masterPasswordSA, encryptedMasterPassword))).Replace("-", "");
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

        public string GeneratePassword()
        {
            string digits       = "0123456789";
            string specialChars = "!@#$%^&*()-_=+<,>.";
            string upperLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lowerLetters = "qwertyuiopasdfghjklzxcvbnm";

            /*
            string[] alphabet = { upperLetters, lowerLetters, digits, specialChars };
            int partition = GENERATED_PASSWORD_LENGTH / 4;
            int[] counter = { partition, partition, partition, partition };
            */

            string validChars = upperLetters + lowerLetters + digits + specialChars;

            StringBuilder result = new StringBuilder();;
            Random rand = new Random();

            for (int i = 0; i < GENERATED_PASSWORD_LENGTH; i++)
                result.Append(validChars[rand.Next(validChars.Length)]);

            return result.ToString();
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
        public static byte[] Encode_to_PBKDF2_Byte_Hash(string inputData)
        {
            /* Generate a salt
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);*/

            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(inputData, CONSTANT_SALT, ITERATIONS);
            return pbkdf2.GetBytes(HASH_SIZE);
        }
    }
}
