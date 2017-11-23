using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding
{
    public partial class Form1 : Form
    {
     
        private String filePath;
        public static Boolean stopToken = false;

        public Form1()
        {
            InitializeComponent();
        }

        private async void  StartBtn_Click(object sender, EventArgs e)

        {
            //this.progressBar1.Value = 0;
            //progressBar1.Update();
            stopToken = false;
            filePath = PathText.Text;
            String key = PasswordText.Text;
            String result;
            this.labelInformation.Text = " Please wait...";
            DisableButtons();

            if (string.IsNullOrEmpty(filePath))

            {
                MessageBox.Show("No document chosen");
                return;
            }

            if (string.IsNullOrEmpty(key))

            {
                MessageBox.Show("No key");
                return;
            }


            if (Path.GetExtension(PathText.Text) == ".txt")


            {
                if (!stopToken)// if we did not press the stop button
                {
                    //this.labelInformation.Text = "Reading";
                    result = await ReadFileAsync();
                    progressBar1.Value = 25;
                    progressBar1.Update();
                    
                    // MessageBox.Show(result);
                    //this.labelInformation.Text = "Reading completed";
                   
                    if (!stopToken)// if we did not press the stop button
                    {
                        if (this.EncodeBtn.Checked)
                        {
                            if (MyCoder.IsBase64Encoded(result))
                            {
                                MessageBox.Show("The text is alredy encoded");
                                Reset();
                                return;
                            }
                            else
                            {
                                //this.labelInformation.Text = " Encoding";
                                Task<string> encodingTask = new Task<string>(() => MyCoder.MyEncoder(result, key));

                                encodingTask.Start();
                                //encodingTask.Wait();
                                result = encodingTask.Result;
                                //MessageBox.Show(result);
                                //this.labelInformation.Text = "Encoding completed";
                                this.progressBar1.Value = 75;
                                progressBar1.Update();
                            }
                        }
                        else if (this.DecodeBtn.Checked)
                        {
                            if (!MyCoder.IsBase64Encoded(result))
                            {
                               MessageBox.Show("It is impossible to decode the text with this decoder", "ERROR!");
                                Reset();
                                return;
                            }
                            else

                            {
                                //this.labelInformation.Text = " Decoding";
                                Task<string> decodingTask = new Task<string>(() => MyCoder.MyDecoder(result, key));
                                decodingTask.Start();
                                //decodingTask.Wait();
                                result = decodingTask.Result;
                                // MessageBox.Show(result);
                                //this.labelInformation.Text = "Decoding completed";
                                this.progressBar1.Value = 75;
                                progressBar1.Update();
                            }
                        }

                    }
                    else return;

                    if (!stopToken)// if we did not press the stop button
                    {
                       // this.labelInformation.Text = "Writing";
                        await  WriteToFileAsync(result);

                       
                        //this.labelInformation.Text = "Writing completed";
                        
                        this.progressBar1.Value = 100;
                        progressBar1.Update();

                        DialogResult res = MessageBox.Show("The operation is completed succesfully!\n Do you want to open the file?", "Congratulation!", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            Process.Start(filePath);
                        }

                        Reset();
                        return;
                    }
                    else return;
                }
                else return;
            }

            else
            throw new Exception("Please, choose a *.txt file.");



        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            stopToken =true;
            Reset();
        }

        public void EnableButtons()
        {
            this.StartBtn.Enabled = true;
            this.StopBtn.Enabled = false;
            
        }

        public void DisableButtons()
        {
            this.StartBtn.Enabled = false;
            this.StopBtn.Enabled = true;

        }

        private void Reset()
        {
            stopToken = true;
            this.progressBar1.Value = 0;
            progressBar1.Update();
            this.labelInformation.Text = "";
            EnableButtons();

        }

        private void EncodeBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DecodeBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FileFindBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdl = new OpenFileDialog();

            fdl.InitialDirectory = @"c:\";
            fdl.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            fdl.RestoreDirectory = true;
            fdl.CheckFileExists = true;
            fdl.CheckPathExists = true;
            
            if (fdl.ShowDialog() == DialogResult.OK)
            {
                this.PathText.Text = fdl.FileName;

            }
        }

        
         private async Task WriteToFileAsync(string outStr)
         {
            try
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    await sw.WriteAsync(outStr);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private async Task<String> ReadFileAsync()
        {
           
            try {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    return await sr.ReadToEndAsync();
                   
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        
    }
}
