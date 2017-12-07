using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace WebTalk
{
    public class WebTalk : MonoBehaviour
    {
        public static string base_url = "http://nerd-of-the-night.dev";

        public bool Registered
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public List<string> Scores
        {
            get;
            private set;
        }

        private string EncryptString(string plainText, byte[] key, byte[] iv)
        {
            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Convert the plainText string into a byte array
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            // Encrypt the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Complete the encryption process
            cryptoStream.FlushFinalBlock();

            // Convert the encrypted data from a MemoryStream to a byte array
            byte[] cipherBytes = memoryStream.ToArray();

            // Close both the MemoryStream and the CryptoStream
            memoryStream.Close();
            cryptoStream.Close();

            // Convert the encrypted byte array to a base64 encoded string
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

            // Return the encrypted data as a string
            return cipherText;
        }

        private string DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            // Will contain decrypted plaintext
            string plainText = String.Empty;

            try
            {
                // Convert the ciphertext string into a byte array
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                // Decrypt the input ciphertext string
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                // Complete the decryption process
                cryptoStream.FlushFinalBlock();

                // Convert the decrypted data from a MemoryStream to a byte array
                byte[] plainBytes = memoryStream.ToArray();

                // Convert the encrypted byte array to a base64 encoded string
                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                // Close both the MemoryStream and the CryptoStream
                memoryStream.Close();
                cryptoStream.Close();
            }

            // Return the encrypted data as a string
            return plainText;
        }

        private string Encrypt(string str, string key)
        {
            // Create sha256 hash
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] x_key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(key));

            // Create secret IV
            byte[] iv = new byte[16] {
                0x01, 0x33, 0x33, 0x55,
                0x33, 0x10, 0x55, 0x33,
                0x33, 0x55, 0x10, 0x33,
                0x55, 0x33, 0x33, 0x01
            };

            return this.EncryptString(str, x_key, iv);
        }

        private string Decrypt(string str, string key)
        {
            // Create sha256 hash
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] x_key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(key));

            // Create secret IV
            byte[] iv = new byte[16] {
                0x01, 0x33, 0x33, 0x55,
                0x33, 0x10, 0x55, 0x33,
                0x33, 0x55, 0x10, 0x33,
                0x55, 0x33, 0x33, 0x01
            };

            return this.DecryptString(str, x_key, iv);
        }

        [System.Serializable]
        private class RegisterResult
        {
            public bool success;
            public int id;
            public string device_id;
            public string name;
            public string created_at;
            public string updated_at;

            public static RegisterResult CreateFromJSON(string jsonString)
            {
                return JsonUtility.FromJson<RegisterResult>(jsonString);
            }
        }

        [System.Serializable]
        private class ScoreResult
        {
            public bool success;

            public static ScoreResult CreateFromJSON(string jsonString)
            {
                return JsonUtility.FromJson<ScoreResult>(jsonString);
            }
        }

        private void registerResult(string result)
        {
            Name = result;
        }

        private void scoreResult(bool success, string code)
        {
            if(success && !Scores.Contains(code))
            {
                Scores.Add(code);
            }
        }

        private IEnumerator GetNameCoroutine(Action<string> registerResultCallback)
        {
            string unique_identifier = SystemInfo.deviceUniqueIdentifier;
            string route = base_url + "/register/" + unique_identifier;

            UnityWebRequest www = UnityWebRequest.Get(route);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                // Show results as text
                Debug.Log(www.downloadHandler.text);
                RegisterResult result = RegisterResult.CreateFromJSON(www.downloadHandler.text);

                if (result.success)
                {
                    Registered = true;
                    registerResultCallback(result.name);
                }
            }
        }

        private IEnumerator AddScoreCoroutine(Action<bool, string> scoreResultCallback, string score)
        {
            string unique_identifier = SystemInfo.deviceUniqueIdentifier;
            string route = base_url + "/add_score/" + unique_identifier + "/" + Encrypt(score, unique_identifier);

            UnityWebRequest www = UnityWebRequest.Get(route);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                // Show results as text
                Debug.Log(www.downloadHandler.text);
                ScoreResult result = ScoreResult.CreateFromJSON(www.downloadHandler.text);

                if (result.success)
                {
                    Registered = true;
                    scoreResultCallback(result.success, score);
                }
            }
        }

        public WebTalk()
        {
            Start();
        }

        private void Start()
        {
            if(Scores == null)
            {
                Scores = new List<string>();
            }
        }

        public void register()
        {
            StartCoroutine(GetNameCoroutine(registerResult));
        }

        public void add_score(string score)
        {
            StartCoroutine(AddScoreCoroutine(scoreResult, score));
        }

        public bool is_code_level_unlock(string score)
        {
            return score.Length >= 23 && score[22] == '1';
        }

        public bool is_code_bonus(string score)
        {
            return score.Length >= 23 && score[22] == '0';
        }
    }
}