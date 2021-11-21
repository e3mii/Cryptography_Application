using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OS2_projekt_EmanuelRadotovic
{
    public partial class Main_window : Form
    {
        public List<string> normalTextList { get; set; }
        public string normalTextStr { get; set; }
        public OperacijeFramework encryptFramework = new OperacijeFramework();
        public aesSystem aesSys = new aesSystem();
        public RSACryptoServiceProvider RSA;
        public byte[] textToEncrypt { get; set; }
        public byte[] encryptedText { get; set; }
        string encryptedTextOutput { get; set; }
        public byte[] decryptedText { get; set; }
        string decryptedTextOutput { get; set; }
        public RSAParameters _publickey { get; set; }
        public RSAParameters _privatekey { get; set; }
        public string publicKey { get; set; }
        public string privateKey { get; set; }
        public string stateOfProgram = "";
        public string stateOfProgramDS = "";
        public string generatedKeysRSA = "";
        public string generatedKeyAES = "";
        public byte[] aesKey { get; set; }
        public byte[] aesKeyIV { get; set; }
        public byte[] encryptedAEStext { get; set; }

        //MAIN DIO
        public Main_window()
        {
            InitializeComponent();
        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            loadNTextButton.Enabled = false;
            encrptAESButton.Enabled = false;
            decrptAESButton.Enabled = false;
            encryptButton.Enabled = false;
            decryptButton.Enabled = false;
            SHA1button.Enabled = false;
            SignButton.Enabled = false;
            verifyButton.Enabled = false;
            loadDSButton.Enabled = false;
        }

        private void Main_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            backupProcess();
            MessageBox.Show("Text file for encryption backed up!");
        }

        public void CheckFileForUpdate()
        {
            normalTextStr = encryptFramework.LoadNormalTextStr();
            string textTOCheckInApp = normalTextBox.Text;
            if (normalTextStr != textTOCheckInApp)
            {
                loadNTextButton.Text = "Load text\n(FILE UPDATED)";
            } else
            {
                loadNTextButton.Text = "Load text";
            }
        }

        public void ShowNormalText()
        {
            normalTextBox.Clear();
            normalTextStr = encryptFramework.LoadNormalTextStr();
            normalTextBox.Text = normalTextStr;
        }

        private void loadNTextButton_Click(object sender, EventArgs e)
        {
            ShowNormalText();
            CheckFileForUpdate();
            chechForState();
            SHA1button.Enabled = true;
        }

        public void chechForState()
        {
            if (stateOfProgram == "RSA")
            {
                encrptAESButton.Enabled = false;
                decrptAESButton.Enabled = false;
                loadDSButton.Enabled = false;
                SignButton.Enabled = false;
                verifyButton.Enabled = false;
            }
            if (stateOfProgram == "AES")
            {
                encryptButton.Enabled = false;
                decryptButton.Enabled = false;
                loadDSButton.Enabled = false;
                SignButton.Enabled = false;
                verifyButton.Enabled = false;
            }
            if (stateOfProgram == "")
            {
                encrptAESButton.Enabled = true;
                decrptAESButton.Enabled = false;
                encryptButton.Enabled = true;
                decryptButton.Enabled = false;
                loadDSButton.Enabled = true;
            }
        }

        private void backupProcess()
        {
            encryptFramework.Backup();
            encryptedTextBox.Clear();
            decryptedTextBox.Clear();
            decrptAESButton.Enabled = false;
            decryptButton.Enabled = false;
            CheckFileForUpdate();
            stateOfProgram = "";
        }

        private void SHA1button_Click(object sender, EventArgs e)
        {
            sha1TxtBox.Clear();
            sha1TxtBox.Text = encryptFramework.MessageDigest();
            encryptFramework.writeMessageDigest(sha1TxtBox.Text);
        }

        //ASYMMETRIC DIO
        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (generatedKeysRSA == "da")
            {
                try
                {
                    stateOfProgram = "RSA";
                    chechForState();
                    encryptedTextBox.Clear();
                    decryptedTextBox.Clear();
                    RSA = new RSACryptoServiceProvider();
                    RSA.ImportParameters(_publickey);
                    string textToEncryptFromFile = encryptFramework.LoadNormalTextStr();
                    textToEncrypt = Encoding.UTF8.GetBytes(textToEncryptFromFile);
                    encryptedText = RSA.Encrypt(textToEncrypt, false);
                    encryptedTextOutput = Convert.ToBase64String(encryptedText);
                    foreach (var item in encryptedTextOutput)
                    {
                        encryptedTextBox.Text += item;
                    }
                    encryptFramework.WriteText(encryptedTextOutput);
                    decryptButton.Enabled = true;
                    CheckFileForUpdate();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data is to large to encrypt...\nProcess of encryption canceled!\nFile restored from backup(PRESENTATION PURPOSE ONLY)", "FILE SIZE ERROR");
                    backupProcess();
                    chechForState();
                }
            }
            else
            {
                MessageBox.Show("Asymmetric RSA keys are not generated!");
            }
            
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                stateOfProgram = "";
                chechForState();
                encrptAESButton.Enabled = true;
                decrptAESButton.Enabled = true;
                decryptedTextBox.Clear();
                encryptedTextBox.Clear();
                RSA.ImportParameters(_privatekey);
                decryptedText = RSA.Decrypt(encryptedText, false);
                decryptedTextOutput = Encoding.ASCII.GetString(decryptedText);
                foreach (var item in decryptedTextOutput)
                {
                    decryptedTextBox.Text += item;
                }
                encryptFramework.WriteText(decryptedTextOutput);
                decryptButton.Enabled = false;
                decrptAESButton.Enabled = false;
                CheckFileForUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("The keys have been changed...\nProcess of decryption canceled!\nFile restored from backup(PRESENTATION PURPOSE ONLY)", "KEYS ERROR");
                backupProcess();
                chechForState();
            }
        }

        private void genrateKeys_Click(object sender, EventArgs e)
        {
            generatedKeysRSA = "da";
            publicKeyTextBox.Clear();
            privateKeyTextBox.Clear();
            RSA = new RSACryptoServiceProvider(); 
            _publickey = RSA.ExportParameters(false);
            _privatekey = RSA.ExportParameters(true);
            publicKey = RSA.ToXmlString(false);
            privateKey = RSA.ToXmlString(true);
            encryptFramework.WritePublicKey(publicKey);
            encryptFramework.WritePrivateKey(privateKey);
            publicKeyTextBox.Text = publicKey;
            privateKeyTextBox.Text = privateKey;
            loadNTextButton.Enabled = true;
            loadDSButton.Enabled = true;
        }

        //DIGITALNI POTPIS
        public void checkForStateDigitalSigniture()
        {
            if (stateOfProgramDS == "DS")
            {
                SignButton.Enabled = true;
                verifyButton.Enabled = true;
            }
            if (stateOfProgramDS == "")
            {
                SignButton.Enabled = false;
                verifyButton.Enabled = false;
            }
        }

        public void ShowDigitalSigniture()
        {
            stateOfProgramDS = "DS";
            DStxtBox.Clear();
            DStxtBox.Text = encryptFramework.LoadTxtForSigniture();
            signitureTxtBox.Clear();
            if (encryptFramework.LoadSigniture().Length <= 1)
            {
                signitureTxtBox.Text = "--no signiture--";
            } else
            {
                signitureTxtBox.Text = encryptFramework.LoadSigniture();
            }
        }

        private void loadDSButton_Click(object sender, EventArgs e)
        {
            ShowDigitalSigniture();
            checkForStateDigitalSigniture();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (generatedKeysRSA == "da")
            {
                SHA256 sha256Hash = SHA256.Create();
                string TextToSign = DStxtBox.Text;
                byte[] hashTextToSign = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(TextToSign));
                byte[] signedHashValue;
                RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(RSA);
                rsaFormatter.SetHashAlgorithm("SHA256");
                signedHashValue = rsaFormatter.CreateSignature(hashTextToSign);
                string signitureToStore = Convert.ToBase64String(signedHashValue);
                encryptFramework.writeTxtSigniture(signitureToStore);
                encryptFramework.WriteKeyDS(RSA.ToXmlString(true));
                ShowDigitalSigniture();
                checkForStateDigitalSigniture();
            }
            else
            {
                MessageBox.Show("Asymmetric RSA keys are not generated!");
            }
            
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsaDS = new RSACryptoServiceProvider();
            rsaDS.FromXmlString(encryptFramework.LoadKeyDS());
            RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsaDS);
            rsaDeformatter.SetHashAlgorithm("SHA256");
            SHA256 sha256Hash = SHA256.Create();
            string TextToSign = DStxtBox.Text;
            byte[] hashTextToSign = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(TextToSign));
            byte[] signedHashValue = Convert.FromBase64String(encryptFramework.LoadSigniture());
            if (rsaDeformatter.VerifySignature(hashTextToSign, signedHashValue))
            {
                MessageBox.Show("The signature is valid.");
            }
            else
            {
                MessageBox.Show("The signature is not valid.");
            }
        }

        //SYMMETRIC DIO
        private void genAESbutton_Click(object sender, EventArgs e)
        {
            generatedKeyAES = "da";
            using (Aes aes = Aes.Create())
            {
                aesKey = aes.Key;
                aesKeyIV = aes.IV;
                secretKeyTextBox.Text = Convert.ToBase64String(aes.Key);
                encryptFramework.WriteAESkey(Convert.ToBase64String(aes.Key));
                encryptFramework.WriteAESkeyIV(Convert.ToBase64String(aes.IV));
            }
            loadNTextButton.Enabled = true;
        }

        private void encrptAESButton_Click(object sender, EventArgs e)
        {
            if (generatedKeyAES == "da")
            {
                try
                {
                    stateOfProgram = "AES";
                    chechForState();
                    encryptedTextBox.Clear();
                    decryptedTextBox.Clear();
                    string textToEncryptFromFile = encryptFramework.LoadNormalTextStr();
                    encryptedAEStext = aesSys.EncryptStringToBytes_Aes(textToEncryptFromFile, aesKey, aesKeyIV);
                    encryptedTextBox.Text = Convert.ToBase64String(encryptedAEStext);
                    encryptFramework.WriteText(Convert.ToBase64String(encryptedAEStext));
                    decrptAESButton.Enabled = true;
                    CheckFileForUpdate();
                }
                catch (Exception)
                {
                    MessageBox.Show("Process of encryption canceled!\nFile restored from backup(PRESENTATION PURPOSE ONLY)", "FILE SIZE ERROR");
                    backupProcess();
                    chechForState();
                }
            }
            else
            {
                MessageBox.Show("Symmetric AES keys are not generated!");
            }
        }

        private void decrptAESButton_Click(object sender, EventArgs e)
        {
            try
            {
                stateOfProgram = "";
                chechForState();
                encryptButton.Enabled = true;
                decryptButton.Enabled = true;
                decryptedTextBox.Clear();
                encryptedTextBox.Clear();
                string decryptedAES = aesSys.DecryptStringFromBytes_Aes(encryptedAEStext, aesKey, aesKeyIV);
                decryptedTextBox.Text = decryptedAES;
                encryptFramework.WriteText(decryptedAES);
                decrptAESButton.Enabled = false;
                decryptButton.Enabled = false;
                CheckFileForUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("The keys have been changed...\nProcess of decryption canceled!\nFile restored from backup(PRESENTATION PURPOSE ONLY)", "KEYS ERROR");
                backupProcess();
                chechForState();
            }
        }
    }
}
