using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speech_Test
{
    public partial class frmMain : Form
    {
        SpeechSynthesizer voice = new SpeechSynthesizer();
        SpeechRecognitionEngine inputVoice = new SpeechRecognitionEngine();
        public frmMain()
        {
            InitializeComponent();            
        }       
        
        
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            speak();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;        
            inputVoice.RecognizeAsync(RecognizeMode.Multiple);
            btnStopListening.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "Yellow", "Green", "Gray", "Close program", "Do you know Zach", "Do you know Kyle", "Do you know Brad", "Do you know Brian", "Do you know Dana", "Do you know Ed", "Do you know Pito", "Do you know Rich", "Do you know Jared", "Do you know Karen", "Do you know Carla", "Do you know Ron", "Do you know Ricky", "Do you know Brondo", "What are you working on", "Do you know Tiffanie", "Do you know Sophia", "Do you know Brayden", "Do you know Leo", "Do you know Rajan", "Who is this", "Do you know Glenn" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammer = new Grammar(gBuilder);

            inputVoice.LoadGrammarAsync(grammer);
            inputVoice.SetInputToDefaultAudioDevice();
            inputVoice.SpeechRecognized += inputVoice_SpeechRecognized;
            
        }

        private void speak()
        {
            //voice.SelectVoiceByHints(VoiceGender.Male);
            voice.SelectVoiceByHints(VoiceGender.Female);
            voice.SpeakAsync(txtWords.Text.Replace("\r\n", " "));
        }

        private void inputVoice_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "Do you know Brayden":
                    txtWords.Text = "I know Brayden, he is a lazy piece of shit";
                    speak();
                    break;
                case "Yellow":
                    txtWords.Text = "You said yellow";
                    btnListen.BackColor = Color.Yellow;
                    break;
                case "Green":
                    txtWords.Text = "You said green";
                    btnListen.BackColor = Color.Green;
                    break;
                case "Gray":
                    txtWords.Text = "You said gray";
                    btnListen.BackColor = Color.Gray;
                    break;
                case "Do you know Glenn":
                    txtWords.Text = "I know Glenn, he is very rich";
                    speak();
                    break;
                case "Do you know Leo":
                    txtWords.Text = "I know Leo, he is the king of bowling";
                    speak();
                    break;
                case "Do you know Rajan":
                    txtWords.Text = "I know Rajan, he is the master of the scrums";
                    speak();
                    break;
                case "Do you know Zach":
                    txtWords.Text = "I know Zach, he used to have great hair and he likes Fit Crunch bars";
                    speak();
                    break;
                case "Do you know Kyle":
                    txtWords.Text = "I know Kyle, he wears glasses and likes chimichangas";
                    speak();
                    break;
                case "Do you know Brad":
                    txtWords.Text = "I know Brad, he eats his own poop";
                    speak();
                    break;
                case "Do you know Brian":
                    txtWords.Text = "I know Brian, he wears cool glasses";
                    speak();
                    break;
                case "Do you know Dana":
                    txtWords.Text = "I know Dana, she has an M and M waterfall fountain";
                    speak();
                    break;
                case "Do you know Ed":
                    txtWords.Text = "I know Ed, the goonies found his treasure";
                    speak();
                    break;
                case "Do you know Pito":
                    txtWords.Text = "I know P 2, he likes origamy";
                    speak();
                    break;
                case "Do you know Rich":
                    txtWords.Text = "I know Rich, he is a big fan of LeBron Jones of the Las Angeles Lakers";
                    speak();
                    break;
                case "Do you know Jared":
                    txtWords.Text = "I know Jared, he is extremely large and has poor circulation.  Every day at 4:45 he gets his pump shake started";
                    speak();
                    break;
                case "Do you know Karen":
                    txtWords.Text = "I know Karen, she likes Mike Tomlin";
                    speak();
                    break;
                case "Do you know Carla":
                    txtWords.Text = "I know Carla, she likes Medfusion";
                    speak();
                    break;
                case "Do you know Ron":
                    txtWords.Text = "I know Ron, he is the captain of a small boat";
                    speak();
                    break;
                case "Do you know Brondo":
                    txtWords.Text = "It's got electrolytes";
                    speak();
                    break;
                case "What are you working on":
                    txtWords.Text = "Get out of my area.  I am trying to catch up on my sleep";
                    speak();
                    break;
                case "Do you know Tiffanie":
                    txtWords.Text = "I know Tiffanie.  She is the most beautiful woman in the world";
                    speak();
                    break;
                case "Do you know Sophia":
                    txtWords.Text = "I know Sophia.  She doesn't like to eat her dinner";
                    speak();
                    break;
                case "Who is this":
                    txtWords.Text = "Wouldn't you like to know";
                    speak();
                    break;                    
                case "Close program":
                    this.Close();
                    break;                    
                default:
                    txtWords.Text = e.Result.Text;
                    break;
            }
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            btnStopListening.Enabled = false;
            inputVoice.RecognizeAsyncStop(); 
            btnListen.Enabled = true;
        }
    }
}
