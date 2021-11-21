using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace OS2_projekt_EmanuelRadotovic
{
    public class OperacijeFramework
    {
        public void writeMessageDigest(string txtToWrite)
        {
            string filePath = @"..\..\test_datoteke\sazetak.txt";
            File.WriteAllText(filePath, txtToWrite);
        }

        public string MessageDigest()
        {
            string textToDigest = LoadNormalTextStr();
            SHA1CryptoServiceProvider txtShortSystem = new SHA1CryptoServiceProvider();
            txtShortSystem.ComputeHash(ASCIIEncoding.ASCII.GetBytes(textToDigest));
            byte[] shortenBytes = txtShortSystem.Hash;
            StringBuilder finalSHA1 = new StringBuilder();
            foreach (var item in shortenBytes)
            {
                finalSHA1.Append(item.ToString("x2"));
            }
            return finalSHA1.ToString();
        }

        public string LoadNormalTextStr()
        {
            string filePath = @"..\..\test_datoteke\Tekst_za_kriptiranje.txt";
            string textToEncrypt = File.ReadAllText(filePath);
            return textToEncrypt;
        }

        public void WriteText(string textToGo)
        {
            string filePath = @"..\..\test_datoteke\Tekst_za_kriptiranje.txt";
            File.WriteAllText(filePath, textToGo);
        }

        public void WritePublicKey(string publicKey)
        {
            string filePath = @"..\..\test_datoteke\javni_kljuc.txt";
            File.WriteAllText(filePath, publicKey);
        }

        public void WritePrivateKey(string privateKey)
        {
            string filePath = @"..\..\test_datoteke\privatni_kljuc.txt";
            File.WriteAllText(filePath, privateKey);

        }

        public string LoadPublicKey()
        {
            string filePath = @"..\..\test_datoteke\javni_kljuc.txt";
            string publicKey = File.ReadAllText(filePath);
            return publicKey;
        }

        public string LoadPrivateKey()
        {
            string filePath = @"..\..\test_datoteke\privatni_kljuc.txt";
            string privateKey = File.ReadAllText(filePath);
            return privateKey;
        }

        public void Backup()
        {
            List<string> output = new List<string>();
            string filePath = @"..\..\test_datoteke\Tekst_za_kriptiranje.txt";
            string backupFilePath = @"..\..\test_datoteke\Tekst_za_kriptiranje(backup).txt";
            List<string> backup = File.ReadAllLines(backupFilePath).ToList();
            File.WriteAllLines(filePath, backup);
        }

        public string LoadTxtForSigniture()
        {
            string filePath = @"..\..\test_datoteke\Tekst_za_digitalni_potpis.txt";
            string textToEncrypt = File.ReadAllText(filePath);
            return textToEncrypt;
        }

        public string LoadKeyDS()
        {
            string filePath = @"..\..\test_datoteke\kljuc_digital_signiture.txt";
            string keyDS = File.ReadAllText(filePath);
            return keyDS;
        }

        public void WriteKeyDS(string key)
        {
            string filePath = @"..\..\test_datoteke\kljuc_digital_signiture.txt";
            File.WriteAllText(filePath, key);
        }

        public string LoadSigniture()
        {
            string filePath = @"..\..\test_datoteke\digitalni_potpis.txt";
            string signiture = File.ReadAllText(filePath);
            return signiture;
        }

        public void writeTxtSigniture(string signiture)
        {
            string filePath = @"..\..\test_datoteke\digitalni_potpis.txt";
            File.WriteAllText(filePath, signiture);
        }

        public void WriteAESkey(string aesKey)
        {
            string filePath = @"..\..\test_datoteke\tajni_kljuc.txt";
            File.WriteAllText(filePath, aesKey);
        }

        public void WriteAESkeyIV(string aesKey)
        {
            string filePath = @"..\..\test_datoteke\tajni_kljuc_iv.txt";
            File.WriteAllText(filePath, aesKey);
        }

        public string LoadAESKey()
        {
            string filePath = @"..\..\test_datoteke\tajni_kljuc.txt";
            string keyDS = File.ReadAllText(filePath);
            return keyDS;
        }

        public string LoadAESKeyIV()
        {
            string filePath = @"..\..\test_datoteke\tajni_kljuc_iv.txt";
            string keyDS = File.ReadAllText(filePath);
            return keyDS;
        }
    }
}
