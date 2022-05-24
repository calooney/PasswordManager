/***************************************************************************
 *                                                                         *
 *  File:        SecurityManager.cs                                        *
 *  Copyright:   (c) 2022, Luca Silviu-Catalin                             *
 *  E-mail:      silviu-catalin.luca@student.tuiasi.ro                     *
 *  Description: In this file you will find the implementation for all     *
 *               security utility related to PasswordManager Application.  *
 *                                                                         *
 ***************************************************************************/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SecurityUtility
{
    public class SecurityManager
    {
        private SymmetricAlgorithm _masterPasswordSA;
        private byte[] _encryptedMasterPassword;

        public SecurityManager(string masterPassword)
        {
            this._masterPasswordSA = new AesManaged();

            _encryptedMasterPassword = SymmetricalEncryptData(_masterPasswordSA, masterPassword);
        }

        /// <summary>
        /// Functie care cripteaza datele de intrare introduse sub forma unui string si
        /// retuneaza le returneaza securizate sub un algoritm custom, tot sub forma de string.
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public string EncryptData(string inputData)
        {
            if (inputData == "")
                return "";

            SymmetricAlgorithm currentAES;
            currentAES = Derive_Key_From_Password_RFC2898(GetMasterPassword());

            return Convert.ToBase64String(SymmetricalEncryptData(currentAES, inputData));
        }

        /// <summary>
        /// Functie care decripteaza datele de intrare introduse sub forma unui string si
        /// retuneaza le returneaza desecurizate, tot sub forma de string.
        /// </summary>
        /// <param name="encrypteInputData"></param>
        /// <returns></returns>
        public string DecryptData(string encrypteInputData)
        {
            if (encrypteInputData == "")
                return "";

            SymmetricAlgorithm currentAES;
            currentAES = Derive_Key_From_Password_RFC2898(GetMasterPassword());
            
            return SymmetricalDecryptData(currentAES, Convert.FromBase64String(encrypteInputData));
        }

        /// <summary>
        /// Functie care genereaza hash-ul SHA256 pentru un set de date.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private string Encode_to_SHA256_string(string inputString)
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

        /// <summary>
        /// Functie care foloseste un SymmetricAlgorith predefinit pentru criptarea setului de date introdus.
        /// </summary>
        /// <param name="aesAlgorithm"></param>
        /// <param name="inputData"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Functie care foloseste un SymmetricAlgorith predefinit pentru decriptarea setului de date introdus.
        /// </summary>
        /// <param name="aesAlgorithm"></param>
        /// <param name="inputEncryptedData"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Functie care deriveaza o cheie de criptare pseudo-aleatoare prin Algoritmul rfc2898.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private SymmetricAlgorithm Derive_Key_From_Password_RFC2898(string password)
        {
            const int DERIVE_KEY_LEN = 256;
            const int DERIVE_ITERATIONS = 9872;
            byte[] DERIVAE_SALT = new byte[] { 1, 2, 23, 234, 37, 48, 134, 63, 248, 4 };


            SymmetricAlgorithm currentAES = new AesManaged();
            
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, DERIVAE_SALT, DERIVE_ITERATIONS))
            {
                if (!currentAES.ValidKeySize(DERIVE_KEY_LEN))
                    throw new InvalidOperationException("Invalid size key");

                currentAES.Key = rfc2898DeriveBytes.GetBytes(DERIVE_KEY_LEN / 8);
                currentAES.IV = rfc2898DeriveBytes.GetBytes(currentAES.BlockSize / 8);
                return currentAES;
            }
        }

        /// <summary>
        /// Functie care returneaza hash-ul parolei master pentru obfuscarea acesteia in mediul de persistenta
        /// </summary>
        /// <returns></returns>
        public string ComputeKeyHash()
        {
            SymmetricAlgorithm currentAES = Derive_Key_From_Password_RFC2898(GetMasterPassword());
            return Encode_to_SHA256_string(ConvertByteToString(currentAES.Key));
        }

        /// <summary>
        /// Functie care descripteaza parola master si o returneaza in 
        /// clar(plain text) pentru folosirea ei in cadrul mediului de securizare
        /// </summary>
        /// <returns></returns>
        private string GetMasterPassword()
        {
            return SymmetricalDecryptData(_masterPasswordSA, _encryptedMasterPassword);
        }

        /// <summary>
        /// Functie wrapper care converteste tipul de date byte la tipul de date string.
        /// </summary>
        /// <param name="inputByte"></param>
        /// <returns></returns>
        private string ConvertByteToString(byte[] inputByte)
        {
            return BitConverter.ToString(inputByte).Replace("-", "");
        }

        /// <summary>
        /// Functie publica prin care se poate valida has-ul parolei stocat in mediul de persistenta.
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public bool ValidatePasswordHash(string hash)
        {
            return (hash == ComputeKeyHash());
        }
    }
}
 