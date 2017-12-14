using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace NerdOfTheNight
{
    public class WebTalk
    {
        private enum ReportingState
        {
            NONE,
            REPORTING,
            REPORTED
        }

        public static string base_url = "http://non.gz0.nl";

        public delegate void RegisterHandler(WebTalk obj, string result);
        public event RegisterHandler OnRegisterSuccess;
        public delegate void ScoreHandler(WebTalk obj, string score);
        public event ScoreHandler OnScoreAdded;
        public event RegisterHandler OnRegisterFail;
        public event ScoreHandler OnScoreFailed;

        public DateTime LastRegistered
        {
            get;
            private set;
        }

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

        private Dictionary<string, ReportingState> Scores;

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

            return this.EncryptString(str, x_key, iv).Replace('/', '-');
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

            return this.DecryptString(str.Replace('-', '/'), x_key, iv);
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

        private void registerResult(bool success, string result)
        {
            if (success)
            {
                Name = result;
                Registered = true;
                LastRegistered = DateTime.Now;
                if (OnRegisterSuccess != null)
                {
                    OnRegisterSuccess(this, result);
                }
            }
            else if(OnRegisterFail != null)
            {
                OnRegisterFail(this, result);
            }
        }

        private void scoreResult(bool success, string code)
        {
            if(success)
            {
                if (OnScoreAdded != null)
                {
                    OnScoreAdded(this, code);
                }
            }
            else if(OnScoreFailed != null)
            {
                OnScoreFailed(this, code);
            }
        }

        private void GetNameCoroutine()
        {
            string unique_identifier = SystemInfo.deviceUniqueIdentifier;
            string route = base_url + "/register/" + unique_identifier;

            UnityWebRequest www = UnityWebRequest.Get(route);
            var req = www.SendWebRequest();
            req.completed += NameRequestCompleted;
        }

        private void NameRequestCompleted(AsyncOperation obj)
        {
            UnityWebRequestAsyncOperation oper = obj as UnityWebRequestAsyncOperation;
            UnityWebRequest www = oper.webRequest;

            if (www.isNetworkError || www.isHttpError)
            {
                //Debug.Log(www.error);
                registerResult(false, "");
            }
            else
            {
                // Show results as text
                //Debug.Log(www.downloadHandler.text);
                RegisterResult result = RegisterResult.CreateFromJSON(www.downloadHandler.text);
                registerResult(result.success, result.name);
            }

            www.Dispose();
        }

        private void AddScoreCoroutine(string score)
        {
            string unique_identifier = SystemInfo.deviceUniqueIdentifier;
            string route = base_url + "/add_score/" + unique_identifier + "/" + Encrypt(score, unique_identifier);

            UnityWebRequest www = UnityWebRequest.Get(route);
            var req = www.SendWebRequest();
            req.completed += ScoreRequestCompleted;
        }

        private void ScoreRequestCompleted(AsyncOperation obj)
        {
            UnityWebRequestAsyncOperation oper = obj as UnityWebRequestAsyncOperation;
            UnityWebRequest www = oper.webRequest;

            string unique_identifier = SystemInfo.deviceUniqueIdentifier;
            string[] segments = www.url.Split('/');
            string code = "";
            if (segments.Length > 0)
            {
                code = Decrypt(segments[segments.Length - 1], unique_identifier);
            }

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                bool should_add = hashes.Contains(sha256_hash(code)) && !Scores.ContainsKey(code);

                try
                {
                    scoreResult(should_add, code);
                }
                finally
                {
                    if (should_add)
                    {
                        Scores.Add(code, ReportingState.NONE);
                    }
                    www.Dispose();
                }
            }
            else
            {
                // Show results as text
                //Debug.Log(www.downloadHandler.text);
                ScoreResult result = ScoreResult.CreateFromJSON(www.downloadHandler.text);

                try
                {
                    scoreResult(result.success, code);
                }
                finally
                {
                    if (!Scores.ContainsKey(code))
                    {
                        Scores.Add(code, ReportingState.NONE);
                    }

                    if (result.success && Scores[code] != ReportingState.REPORTED)
                    {
                        Scores[code] = ReportingState.REPORTED;
                    }
                    www.Dispose();
                }
            }
        }

        public WebTalk()
        {
            if (Scores == null)
            {
                Scores = new Dictionary<string, ReportingState>();
            }
        }

        public void register()
        {
            GetNameCoroutine();
        }

        public static string sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.ASCII;
                byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public void add_score(string score)
        {
            AddScoreCoroutine(score);
        }

        public bool has_code(string score)
        {
            return Scores.ContainsKey(score);
        }

        public bool is_code_level_unlock(string score)
        {
            return score.Length >= 23 && score[22] == '1';
        }

        public bool is_code_bonus(string score)
        {
            return score.Length >= 23 && score[22] == '0';
        }

        public List<string> GetScores()
        {
            return new List<string>(Scores.Keys);
        }

        public void ReportUnreportedScores()
        {
            List<string> score_keys = GetScores();
            foreach(var entry in score_keys)
            {
                if(Scores[entry] == ReportingState.NONE)
                {
                    Scores[entry] = ReportingState.REPORTING;
                    add_score(entry);
                }
            }
        }

        private static HashSet<string> hashes = new HashSet<string>
        {
            "87944236cbb42f611359c56d9dda5c7ce798088af8476deb473f601eb38210ef",
            "2afe173979d3092609be0507adf4c3381577c6838de88955600941cb9a35621a",
            "38af60cfc86d00877a4c94d2ecdd5fb206f7a3c09acf1152eb916c3899ec5b37",
            "ad1b7c5dda8bc9fba015ef055a6d9053f6a1289bcfa957a7a7a22ca5bdae4b0a",
            "bdd11d0a084069385af628826032ea2734c248aa44454cb6f79227d3f83e0edb",
            "e3c6e47aaf5db75ff2ad5a0b2e1c7cca38a3e04235c137e6a2c6a04e35f79b1d",
            "8f97a9934951aad9c559a6ed254be1eb725260207d0bcc3d0172347bf9917966",
            "f8719e394c95f3469e435b80704723751cbdf846201d598ab431eaf643ad5570",
            "71f1754bc9b335d0a6fdab2950e8857b92efc137acb8fbfbb68d0bedf1cc9a66",
            "9debc6872bfddd01bb07c2a2b41657b7deb2d10aa84f2152c32b79e81cbd6ba2",
            "aedc3525df70e090b5f5df19423865814b899104aa8273d824782ee0e617a720",
            "5f3b3097fca9ce792a1a906e7e3484e70419e315a60b479a36e2f8969f70601b",
            "6f1bedb80902b139e572bafe71805adbe33871147343c23554476499e6c98cc0",
            "44df6fab396330cb1e924cb1f27acc8f7bad2e4c6bfe394e40bbb4078b2ec08e",
            "8778deee70dc86dac021f6d2ef09dd2d71e11e4c6fed37fcf5672223fd9c2b0a",
            "a4187dcc21012e3974b35c46b2e11dae32dfa98698a8a2666aaba458db2f1fa9",
            "c9c58ea31838b22048fb8e4b45a994a7947e4114c0bf3e7d8811e5efd978ee64",
            "04faedaef0c5589b9213d88527a5a8b06de43fe443403e1147ef1bd8e810c29b",
            "7b37ce0bf9221a672f61a3564c8cf8ef8b7cfc9094714d858c79c71037ccf356",
            "062b57d7ecc9436e58e3331e13bedff5cf63740c14d067b43299db4a1de5b73a",
            "4def788c83bb341a6a0e96d1933adcf1d1c91a4d4c736e65efccf48503c0683d",
            "5cefacf37af8f624940caeb741f0c5baf92ce7964c03a274328fabe84082ae3b",
            "0705544af046aa2cfae39d27dd92d6820993967f0de3f42f1ee1c95b2a58d9d1",
            "6bb127a3db39dbdbf8b64dbfc20ce6b18bb79965d8676a40eeb3bef9c6e34648",
            "1c344c96601a5b6a849e8272079ae79783e57a47167ed2fb34563c35c50c0511",
            "5335cd6fd5d5a6dd92583b84c18c13c1262bbe851a14fc3574bff7c8b7722d99",
            "d57197cbc505f304086b95d436503d547dd76c652e90370ad30d975a2d33c14c",
            "bb82c63a27b5ed493fe782eca0154143bcb1038455a4bb2f73de8558d7b17ded",
            "ba70ebc4aa1654700054048ce1fe7b6e5d74f7a6ab7a87439a6ae7a394f6c7ec",
            "95c6b6351376a432fe1c5a5a5cad8184cb1e8e49867ae4788f612435a32fc3fa",
            "8e2691b3c1c78bd38787068615be02d900cf8340abdab0bb216d94cc89c4f01a",
            "579dbf09162354f45692a7f562454b0d9827084e288083e667bb338e6eb2b9cc",
            "164c81e9a3538cb72c356a92fa8f9f722b0134e93961c9d5757ec21e04e9a59a",
            "c09e5a148e6f934eca117b6925e8dacaa8413e10be819c18c5e05ce3c5014299",
            "7c029f5552531f87fce9c2e3ccc1285da1144149c891caf053514b64de84a3b0",
            "512f3ecbcf04415a7b92eca3914542891b9eff312975e3018184b5e3a544ac25",
            "64633f8802668b3c52950ab027f94c28dfcf3c3f5f182fa8e6d7ebce5334f061",
            "f1ef23d44090a00f2f18e6291680e926f9189abddaefa27ca15792d0f5899a61",
            "4347aa5278ad4da548227bb520140f6281123f46ed7b624dfefd11828497c045",
            "931dae9fb7461b6d45dc68158ef9005cada00c5a2dd30205e57c26c97ad0d1ef",
            "2014f98f34248560aca2dddcf9d25669c0f0783281f9524256bbe977184ad6ec",
            "673d465549bfe85400b532f25c4f13a2c4233513c68aa4997cb27c0425bc620f",
            "6bc504efa0d49d996edc7484ec789dd3fe7e029675ef2bcf258182e1d92aa56e",
            "9262f8b5d5e11515ce907d96db1fbcf74fe29fb81f0053e2546991d63d85df32",
            "4a0a0d7f9b50280ce2ca9a09965fd6ca7add91ac71f7687ace98288be4938431",
            "dec9711c2aa39e2e5c5875cbd8831764847d629ed28bdebe2ba2d6a145ca4da7",
            "18f294da17ae458b58ce31dad22c38fe36e066c2aaa0ef99009bf2dabf6a44fa",
            "5af8db9d203f8969bd0147e732f9b49dd622e33f3df8f51c41b50dfe5a73dc19",
            "ad1bfab76be91f1c4845367c5cea43e3c96374c94144858619f8a0256128d415",
            "b062859289be25f07c17504708bdcb03fdacf053d2acb65816f3699d7e294f54",
            "9024e536059807fe3d5abc00a23d4b8ebb54e901df637e37cb1c345121ab4578",
            "47936275d20d8d5e4b3043c9f13053acbd18f6fefd93fcc55a9155fe1b7f0f3d",
            "6195766efb982371d2d67c8ea753c1d9f3d17b942679f99dcc298cd79cc1aeb7",
            "521fbcc9b7294c99e39ec1881c84134fd54790c35c26e5b1f1f51b4e8dfa6c0f",
            "2e17302905c9e41afd982ea23f074b48eccffbdd6ece747f04e2c81ce8b7c62a",
            "fcefe7f04d2fa803857134f6ca89c360565f5d1440dd125b6872e23699254f28",
            "80e9cb1a0a3069fcd29b6852d8e905ffeca0c8262b91e779402505670efc79f2",
            "dcc82b5613872e365e815cf5c57eaed05d691ede629747ab3a68089de1932203",
            "3c5ed663355adb22b3dc574a17b9185ecb595bf330c868208d541da9da5f05fd",
            "f6ca36833c6959c0dc0f04d9a1c307c38ed6aa76f8ef78db2801357cc2a8f87e"
        };
    }
}