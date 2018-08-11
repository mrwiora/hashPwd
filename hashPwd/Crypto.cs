using System;
using System.Security.Cryptography;
using System.Text;

namespace hashPwd
{
    public static class Crypto
    {
        #region Methods

        /// <summary>
        /// Compute new hash from password and optional salt
        /// </summary>
        /// <param name="varToHash">Value to Hash</param>
        /// <param name="varSalt">Salt Value</param>
        /// <param name="varHashType">Hash Type</param>
        /// <param name="varDoubleType">Double Type</param>
        /// <returns></returns>
        public static String GetHash(String varToHash, String varSalt, String varHashType, String varDoubleType, bool varSaltAppend, bool varBase64)
        {
            var result = string.Empty;

            if (!string.IsNullOrEmpty(varToHash))
            {
                switch (varHashType.ToUpper())
                {
                    case "MD5":
                        result = GenerateHash(MD5.Create(), varToHash, varSalt, varSaltAppend, varBase64);
                        break;

                    case "SHA1":
                        result = GenerateHash(SHA1.Create(), varToHash, varSalt, varSaltAppend, varBase64);
                        break;

                    case "SHA256":
                        result = GenerateHash(SHA256.Create(), varToHash, varSalt, varSaltAppend, varBase64);
                        break;

                    case "SHA512":
                        result = GenerateHash(SHA512.Create(), varToHash, varSalt, varSaltAppend, varBase64);
                        break;

                    default:
                        result = string.Format("{0}: {1}", Resource.Error, Resource.UnkownHashtype);
                        break;
                }

                switch (varDoubleType.ToUpper())
                {
                    case "MD5":
                        result = GenerateHash(MD5.Create(), result);
                        break;

                    case "SHA1":
                        result = GenerateHash(SHA1.Create(), result);
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// Generate new hash
        /// </summary>
        /// <param name="algo">Algorithm for generating hash</param>
        /// <param name="varToHash">Value to Hash</param>
        /// <param name="varSalt">Salt Value</param>
        /// <returns>Generated hash value</returns>
        private static String GenerateHash(HashAlgorithm algo, String varToHash, String varSalt = "", bool varSaltAppend = true, bool varBase64 = true)
        {
            var varToHashSum = "";
            if (varSaltAppend) {
                varToHashSum = varToHash + varSalt;
            } else
            {
                varToHashSum = varSalt + varToHash;
            }
            var hash = algo.ComputeHash(Encoding.UTF8.GetBytes(varToHashSum));
            var digest = new StringBuilder();
            var generatedHash = "";

            foreach (var n in hash)
            {
                digest.Append(Convert.ToInt32(n).ToString("x2"));
            }
            if (varBase64)
            {
                generatedHash = Base64Encode(digest.ToString());
            } else
            {
                generatedHash = digest.ToString();
            }

            return generatedHash;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        #endregion
    }
}
