using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VoiceRecognition
{
    public partial class frmUtama : MetroFramework.Forms.MetroForm
    {

        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public frmUtama()
        {
            InitializeComponent();
        }
       

        string[] data_personal =  { "who are you","what is your name", "GoSmart"
                                    , "hallo", "what are you doing now", "where are you from"
                                    ,"how old are you","thank you","do you know INDONESIA","tell me about Indonesia","tell me about blackhole" };
         
        string[] data_todo = {  "facebook please", "google please","do you know CORTANA"
                                    , "tell me about CORTANA", "lock please", "command prompt"
                                    , "task manager","write my name","youtube please"
                                    , "shutdown please","print all comand","localhost please","clear please","how much culture in indonesia" };

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                string t_ = "Processing ";


               
            
                if (e.Result.Text == data_personal[0])
                {
                    frmlist.addData(t_+"-> " + data_personal[0]);
                    synthesizer.SpeakAsync("no one know who am i, i come from another galaxy");

                }
                else if (e.Result.Text == data_personal[1])
                {
                    frmlist.addData(t_ + "-> " + data_personal[1]);
                    synthesizer.SpeakAsync("My name is GoSmart");
                }
                else if (e.Result.Text == data_personal[2])
                {
                    frmlist.addData(t_ + "-> " + data_personal[2]);
                    synthesizer.SpeakAsync("Yes my bos, What can i do for you ?");
                }
                else if (e.Result.Text == data_personal[3])
                {
                    frmlist.addData(t_ + "-> " + data_personal[3]);
                    synthesizer.SpeakAsync("Yes my bos, i am here");
                }
                else if (e.Result.Text == data_personal[4])
                {
                    frmlist.addData(t_ + "-> " + data_personal[4]);
                    synthesizer.SpeakAsync("Nothing my boss, I am do nothing");
                }
                else if (e.Result.Text == data_personal[5])
                {
                    frmlist.addData(t_ + "-> " + data_personal[5]);
                    synthesizer.SpeakAsync("i come from another galaxy and i live on earth now");
                }
                else if (e.Result.Text == data_personal[6])
                {
                    frmlist.addData(t_ + "-> " + data_personal[6]);
                    synthesizer.SpeakAsync("i do not have age my boss");
                }
               
                else if (e.Result.Text == data_personal[7])
                {
                    frmlist.addData(t_ + "-> " + data_personal[7]);
                    synthesizer.SpeakAsync("you are welcome my boss");
                }
                else if (e.Result.Text == data_personal[8])
                {
                    frmlist.addData(t_ + "-> " + data_personal[8]);
                    synthesizer.SpeakAsync("Yes, I know my boss. Indonesia is great country");
                }
                else if (e.Result.Text == data_personal[9])
                {
                    frmlist.addData(t_ + "-> " + data_personal[9]);
                    synthesizer.SpeakAsync("Indonesia have many culture. Indonesia have beautiful island like BALI, Lombok, Kepulauan Seribu, Raja Ampat. Indonesia have good people, indonesia have much island");
                }
                else if (e.Result.Text == data_personal[10])
                {
                    frmlist.addData(t_ + "-> " + data_personal[10]);
                    synthesizer.SpeakAsync("Blackhole is a region of space having a gravitational, field so intense that no matter or, radiation can escape.");
                    Process.Start("https://www.nasa.gov/audience/forstudents/5-8/features/nasa-knows/what-is-a-black-hole-58.html");

                  
                }
                // =====================================
                else if (e.Result.Text == data_todo[0])
                {
                    frmlist.addData(t_ + "-> " + data_todo[0]);
                    synthesizer.SpeakAsync("ok my boss, please wait, i'm open facebook for you !");
                    Process.Start("https://facebook.com");
                }
                else if (e.Result.Text == data_todo[1])
                {
                    frmlist.addData(t_ + "-> " + data_todo[1]);
                    synthesizer.SpeakAsync("ok my boss, please wait, i'm open google for you !");
                    Process.Start("https://google.com/");
                }
                else if (e.Result.Text == data_todo[2])
                {
                    frmlist.addData(t_ + "-> " + data_todo[2]);
                    synthesizer.SpeakAsync("Yes, i know cortana my boss");
                }
                else if (e.Result.Text == data_todo[3])
                {
                    frmlist.addData(t_ + "-> " + data_todo[3]);
                    synthesizer.SpeakAsync("Cortana is Artificial Intelligence that was created by windows, but cortana is not smart. Cortana and me is same. Do you understand me my bos ?");
                }

                else if (e.Result.Text == data_todo[4])
                {
                    frmlist.addData(t_ + "-> " + data_todo[4]);
                    synthesizer.SpeakAsync("Lock computer");
                    LockWorkStation();
                  
                }
                else if (e.Result.Text == data_todo[5])
                {
                    frmlist.addData(t_ + "-> " + data_todo[5]);
                    synthesizer.SpeakAsync("ok my boss, please wait, i'm open command prompt for you !");
                    Process.Start("cmd");
                }
                else if (e.Result.Text == data_todo[6])
                {
                    frmlist.addData(t_ + "-> " + data_todo[6]);
                    synthesizer.SpeakAsync("ok my boss, please wait, i'm open task manager for you !");
                    Process.Start("taskmgr");
                }
                else if (e.Result.Text == data_todo[7])
                {
                    rt_echo.Text = "";
                    rt_echo.Text = "Lamhot Simamora";
                    frmlist.addData(t_ + "-> " + data_todo[7]);
                    synthesizer.SpeakAsync("ok my boss, your name has been writed");
                   
                }
                else if (e.Result.Text == data_todo[8])
                {
                    frmlist.addData(t_ + "-> " + data_todo[8]);
                    synthesizer.SpeakAsync("ok my boss, please wait, i'm open youtube for you !");
                    Process.Start("https://www.youtube.com/");
                }
                else if (e.Result.Text == data_todo[9])
                {
                    frmlist.addData(t_ + "-> " + data_todo[9]);
                    synthesizer.SpeakAsync("Ok my boss, please wait, i will shutdown the computer !");
                    //  Process.Start("shutdown /s /t 0");
                    // shutdown /s /t 0
                }
                else if (e.Result.Text == data_todo[10])
                {
                  
                    synthesizer.SpeakAsync("Oke my boss. I am print all comand !");
                    printAllComand();

                }
                else if (e.Result.Text == data_todo[11])
                {
                    frmlist.addData(t_ + "-> " + data_todo[11]);
                    synthesizer.SpeakAsync("Oke my boss. I will open localhost");
                    Process.Start("C:/xampp/htdocs");

                }
                else if (e.Result.Text == data_todo[12])
                {

                    synthesizer.SpeakAsync("Oke my boss. I will clear list");
                    frmlist.clearCommand();
                }
                else if (e.Result.Text == data_todo[13])
                {
                    frmlist.addData(t_ + "-> " + data_todo[13]);
                    synthesizer.SpeakAsync("I do not know my boss");
                    
                }
                else
                {
                    frmlist.addData("Searching...");
                    Process.Start("www.google.com/search?site=&source=hp&q=" + e.Result.Text);
                }



            }
            catch (Exception ex)
            {
                frmlist.addData( "Error : "+ex.ToString());
            }


        }
        [DllImport("user32")]
        public static extern void LockWorkStation();
      

        private FrmList frmlist = new FrmList();
        private void frmUtama_Load(object sender, EventArgs e)
        {
            btn_disable_voice.Enabled = false;

            frmlist.Show();


            try
            {
                Choices commands = new Choices();
                commands.Add(new string[] {
                    data_personal[0]
                ,   data_personal[1]
                ,   data_personal[2]
                ,   data_personal[3]
                ,   data_personal[4]
                ,   data_personal[5]
                ,   data_personal[6]
                ,   data_personal[7]
                ,   data_personal[8]
                 ,   data_personal[9]
                  ,   data_personal[10]
                ,   data_todo[0]
                ,   data_todo[1]
                ,   data_todo[2]
                ,   data_todo[3]
                ,   data_todo[4]
                ,   data_todo[5]
                ,   data_todo[6]
                ,   data_todo[7]
                ,   data_todo[8]
                ,   data_todo[9]
                ,   data_todo[10]
                ,   data_todo[11]
                ,   data_todo[12]
                 ,   data_todo[13]
                });




                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(commands);
                Grammar grammar = new Grammar(gBuilder);

                recEngine.LoadGrammarAsync(grammar);
                recEngine.SetInputToDefaultAudioDevice();
                recEngine.SpeechRecognized += recEngine_SpeechRecognized;

               
            }
            catch
            {

            }
        }

        private void btn_enable_voice_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btn_enable_voice.Enabled = false;
            btn_disable_voice.Enabled = true;
        }

        private void btn_disable_voice_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btn_enable_voice.Enabled = true;
            btn_disable_voice.Enabled = false;
        }

        private void btn_talk_Click(object sender, EventArgs e)
        {
            if (rt_echo.Text == string.Empty)
            {
                return;
            }
            synthesizer.SpeakAsync(rt_echo.Text);
        }


        private void printAllComand()
        {
            int lengtData = data_personal.Length;
            frmlist.clearCommand();
            for (int i = 0; i < lengtData; i++)
            {
                frmlist.addData("- " + data_personal[i]);
            }
            int lengthTodo = data_todo.Length;

            for (int j = 0; j < lengthTodo; j++)
            {
                frmlist.addData(" - " + data_todo[j]);
            }
        }

      

        private void btn_print_command_Click(object sender, EventArgs e)
        {
            printAllComand();
        }
    }
}
