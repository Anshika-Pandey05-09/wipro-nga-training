using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace demo_text_to_speech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the SpeechSynthesizer class
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();// Create an object of the SpeechSynthesizer class
            Console.WriteLine("Enter the text you want to convert to speech:");
            string text = Console.ReadLine();// Reading the text input from the console
            synthesizer.Speak(text);// method to convert the text to speech
            //can also save the speech to a file
            //changing the voice of the synthesizer into female
            synthesizer.SelectVoiceByHints(VoiceGender.Female);
            synthesizer.Speak(text); //convert the text to speech 
            //can also save the speech to a file
            synthesizer.SetOutputToWaveFile("output.wav"); // Set the output to a wave file
        }
    }
}
