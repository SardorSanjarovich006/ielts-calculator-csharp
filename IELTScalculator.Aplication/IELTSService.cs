using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IELTScalculator.Domain;
using IELTScalculator.Infrastucture;

namespace IELTScalculator.Aplication
{
    public class IELTSService
    {
        public DbContext DbContext { get; set; }
        private int index = 0;
        public IELTSService()
        {
            DbContext = new DbContext();
        }

        public void AddStudent( string fullname, double listening, double reading, double writing, double speaking,double overall)
        {
            if ((index>=DbContext.ielts.Length))
            {
                return;
            }
            var ielts = new IELTS()
            {
                FullName = fullname,
                Listening = listening.ToString(),
                Reading = reading.ToString(),
                Writing = writing.ToString(),
                Speaking = speaking.ToString(),
                Overall = overall.ToString()
            };
        }
        public double HisobListening()
        {
            Console.WriteLine("Birinchi bo'lib Listening band ni xisoblaymiz : ");
            Console.WriteLine("Siz Listeningdan 40 tadan nechtasiga javob berdingiz ?");
            string javob = Console.ReadLine();
            int javob1 = Convert.ToInt32(javob);

            double summ2l = 0;

            if (0 <= javob1 && javob1 <= 40)
            {
                double summl = javob1 * (9.0 / 40);
                int summ1l = (int)summl;

                if ((summl - summ1l) >= 0.75)
                    summ2l = Math.Ceiling(summl);
                else if ((summl - summ1l) <= 0.25)
                    summ2l = Math.Floor(summl);
                else
                    summ2l = summ1l + 0.5;
            }
            else
            {
                Console.WriteLine("Siz xato qiymat kirityapsiz !!!!!");
            }

            return summ2l;
        }

        public double HisobReading()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Yaxshi endi Readinga o'tamiz 40 tadan nechtasiga to'g'ri javob berdingiz ? : ");

            string javobr = Console.ReadLine();
            int javob1r = Convert.ToInt32(javobr);

            double summ2r = 0;

            if (0 <= javob1r && javob1r <= 40)
            {
                double summr = javob1r * (9.0 / 40);
                int summ1r = (int)summr;

                if ((summr - summ1r) >= 0.75)
                    summ2r = Math.Ceiling(summr);
                else if ((summr - summ1r) <= 0.25)
                    summ2r = Math.Floor(summr);
                else
                    summ2r = summ1r + 0.5;
            }
            else
            {
                Console.WriteLine("Siz xato qiymat kirityapsiz !!!!!");
            }

            return summ2r;
        }

        public double HisobWriting()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("Endi Writing bandiga o'tamiz :) Qanday bal oldingiz ? : ");
            string javobw = Console.ReadLine();
            return Convert.ToDouble(javobw);
        }

        public double HisobSpeaking()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("Juddayam yaxshi endi Speakinga o'tamiz . Undan qancha bal oldingiz ? : ");
            string javobs = Console.ReadLine();
            return Convert.ToDouble(javobs);
        }

        public double HisobOverall(double l, double r, double w, double s)
        {
            double overall = (l + r + w + s) / 4.0;
            double Overall = Math.Round(overall * 2) / 2;

            if (Overall == 9) Console.WriteLine("Overall: 9 - Expert");
            else if (Overall == 8.5) Console.WriteLine("Overall: 8.5 - Very Good");
            else if (Overall == 8) Console.WriteLine("Overall: 8 - Very Good");
            else if (Overall == 7.5) Console.WriteLine("Overall: 7.5 - Good");
            else if (Overall == 7) Console.WriteLine("Overall: 7 - Good");
            else if (Overall == 6.5) Console.WriteLine("Overall: 6.5 - Competent");
            else if (Overall == 6) Console.WriteLine("Overall: 6 - Competent");
            else if (Overall == 5.5) Console.WriteLine("Overall: 5.5 - Modest");
            else if (Overall == 5) Console.WriteLine("Overall: 5 - Modest");

            return Overall;
        }


        public void IeltsProcess()
        {
            Console.WriteLine("Judda yaxshi Xurmatli mijoz! O'ylaymizki yaxshi topshirib chiqgansiz :)");
            Console.Write("Keling olgan natijangizni xisoblaymiz . Boshlaymizmi ? ha / yo'q : ");
            string user1 = Console.ReadLine();

            Console.WriteLine("=======================================================================");

            if (user1 == "ha")
            {
                Console.WriteLine("Juda ajjoyib o'ylaymizki natijangiz yuqori chiqadi :) ");
                Console.WriteLine("Qani unda kettik !!!!!! ");

                Console.WriteLine("========================================================================");

                double listening = HisobListening();
                double reading = HisobReading();
                double writing = HisobWriting();
                double speaking = HisobSpeaking();

                Console.WriteLine("====================================================");
                Console.WriteLine("Ho'sh xurmatli mijoz biz sizning Overall balingizni xisoblayapmiz .......");
                Console.Write("Xosh Natijangizni ko'rishga tayyormisiz :) ....... ");
                string natija = Console.ReadLine();

                HisobOverall(listening, reading, writing, speaking);
            }
        }

        public void ShowAllStudents()
        {
            Console.WriteLine("\n=========== SAQLANGAN IELTS NATIJALARI ===========");

            bool bor = false;

            for (int i = 0; i < DbContext.ielts.Length; i++)
            {
                var s = DbContext.ielts[i];
                if (s != null)
                {
                    bor = true;
                    Console.WriteLine($@"
                    Talaba #{i + 1}
                    Ism      : {s.FullName}
                    Listening: {s.Listening}
                    Reading  : {s.Reading}
                    Writing  : {s.Writing}
                    Speaking : {s.Speaking}
                    OVERALL  : {s.Overall}
----------------------------------------------");
                }
            }

            if (!bor)
                Console.WriteLine("Hali hech qanday ma'lumot yo‘q!");
        }




    }
}