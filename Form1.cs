using System.Numerics;

namespace HexViewer
{
    public partial class HexViewer : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        StreamReader sr;
        static int indexLine;
        static int nrMaxChar = 32760;
        static string[] indexLineVector = new string[8];
        public HexViewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(openFile.ShowDialog() == DialogResult.OK)
            {
                indexLine = 0;
                Array.Clear(indexLineVector);
                sr= new StreamReader(openFile.FileName);
                WriteInTextBox(sr);
            }
        }

        private void WriteInTextBox(StreamReader sr)
        {
            HexViewerTextBox.Text = "";
            int Index = 0;
            string stringCaractereInBazaHexa="";
            string continutulUneiLinii="";
            char charToBeTranformed='0';
            do
            {
                charToBeTranformed = (char)sr.Read();
                if ((int)charToBeTranformed < 256)
                {
                    stringCaractereInBazaHexa += ConvertSequenceToHexa(charToBeTranformed) + ' ';
                    Index++;
                }
                else continue;
                if ((int)charToBeTranformed > 32 &&(int)charToBeTranformed<256)
                    continutulUneiLinii += charToBeTranformed;
                else
                    continutulUneiLinii += '.';
                
                
                if (HexViewerTextBox.Text.Length > nrMaxChar) break;
                if(Index==16)
                {
                    HexViewerTextBox.Text += $" {LineIndexString(indexLine)} |{stringCaractereInBazaHexa}|{continutulUneiLinii}\r\n";
                    
                    //Console.WriteLine($" {LineIndexString(indexLine)} |{stringCaractereInBazaHexa}|{continutulUneiLinii}\r\n"); //This line can be used if the output type in project properties is set to console application. It will show only the last few houndred lines
                    Index = 0;
                    indexLine++;
                    continutulUneiLinii = "";
                    stringCaractereInBazaHexa = "";
                }
            } while (sr.Peek()>=0);
            

        }
        private static string LineIndexString(int indexLine)
        {
            int indexLineAux = indexLine;
            Array.Clear(indexLineVector);
            for(int j = 7; j >=0;j--)
            {
                indexLineVector[j] = ConvertNumberToHexa(indexLine%16).ToString();
                indexLine/=16;
            }
            string indexLineString = "";
            for (int j = 0; j <8; j++)
            {
                indexLineString += indexLineVector[j];
            }
            return indexLineString;
        }
        private static string ConvertSequenceToHexa(int numberToBeTranformed)
        {
            string tranformedNumber;
            if(numberToBeTranformed==0)
            {
                tranformedNumber = "00";
                return tranformedNumber;
            }
            if (numberToBeTranformed < 16)
            { 
                tranformedNumber = "0";
                tranformedNumber += ConvertNumberToHexa(numberToBeTranformed % 16);
                return tranformedNumber;
            }
            else tranformedNumber = "";
            char[] charInBase16 = new char[2];
            int i = 0;
            while (numberToBeTranformed!=0)
            {
                charInBase16[i++] = ConvertNumberToHexa(numberToBeTranformed % 16);
                numberToBeTranformed/= 16;
            }
            tranformedNumber = tranformedNumber + charInBase16[1] + charInBase16[0];
            return tranformedNumber;
        }
        private static char ConvertNumberToHexa(int a)
        {
            switch(a)
            {
                case 0: return '0';
                case 1: return '1';
                case 2: return '2';
                case 3: return '3';
                case 4: return '4';
                case 5: return '5';
                case 6: return '6';
                case 7: return '7';
                case 8: return '8';
                case 9: return '9';
                case 10: return 'A';
                case 11: return 'B';
                case 12: return 'C';
                case 13: return 'D';
                case 14: return 'E';
                case 15: return 'F';
                default: return '.';
            }
        }
        private void HexViewerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}