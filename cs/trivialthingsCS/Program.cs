using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using System.Management;
using System.Text.RegularExpressions;
//using System.Windows.Input;
//using dxldllforUnity;
//using Sharpduino;
//using Sharpduino.Constants;
//using dcDLLforUnity;



namespace trivialthingsCS
{
//    public class Alpha
//    {
//        // This method that will be called when the thread is started
//        public int Beta(int i)
//        {
//            int j = 0;
//            while (j < i)
//            {
//                j++;
//                Console.WriteLine("i = {0}, j = {1}", i, j);
//            }
//            return j;
//        }
//    }

    class Program
    {
        //private static void getSerialPort()
        //{
        //    try
        //    {
        //        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");
        //        foreach (ManagementObject queryObj in searcher.Get())
        //        {
        //            try
        //            {
        //                if (queryObj["Caption"].ToString().Contains("COM"))
        //                {
        //                    Console.WriteLine("serial port : {0}", queryObj["Caption"]);
        //                }
        //            }
        //            catch (NullReferenceException)
        //            {
        //                Console.WriteLine("There is error...");
        //            }


        //        }
        //    }
        //    catch (ManagementException e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}

        public static int ConvertToInt(String input)
        {
            // Replace everything that is no a digit.
            String inputCleaned = Regex.Replace(input, "[^0-9]", "");

            int value = 0;

            // Tries to parse the int, returns false on failure.
            if (int.TryParse(inputCleaned, out value))
            {
                // The result from parsing can be safely returned.
                return value;
            }

            return 0; // Or any other default value.
        }

        static void Main(string[] args)
        {
            int[] a = new int[4] { 2, 3, 4, 5 };
            int[] b = a;
            int[] c = new int[4] { 8, 9, 10, 11 };
            foreach (int i in a)
            {
                Console.WriteLine("a:" + i);
            }
            b[3] = 7;
            foreach (int i in b)
            {
                Console.WriteLine("b:" + i);
            }
            b = c;
            foreach (int i in b)
            {
                Console.WriteLine("b:" + i);
            }

            //float range = 2048;
            //float min = 1024;
            //float pos = 0.7561f;
            //float desirePos = (range * pos) + min;

            //Console.WriteLine((int)desirePos);

            //int[] test = new int[4] { 0, 0, 0, 0 };

            //for (int i = 0; i < test.Length; i++)
            //{
            //    Console.WriteLine(test[i]);
            //    if (test[i] == 0)
            //    {
            //        test[i] = 1;
            //    }
            //    Console.WriteLine(test[i]);
            //}

            //foreach (int i in test)
            //{
            //    Console.WriteLine("in foreach: " + i);
            //}

                //string today = DateTime.Now.ToString();
                //DateTime parsedTD = DateTime.Parse(today);

                //Console.WriteLine(today);
                //Console.WriteLine(parsedTD.ToString());


                //string a = "COM15";
                //string b = "//.////";
                //string c = b+a;

                //Console.WriteLine(ConvertToInt(a));
                //Console.WriteLine(c);

                //getSerialPort();

                //string[] ports = SerialPort.GetPortNames();
                //Console.WriteLine("Found ports: ");

                //foreach(string port in ports)
                //{
                //    Console.WriteLine(port);
                //}

                //while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
                //{

                //}

                //int i = 0;
                //int j = 100000;

                //while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
                //{
                //    do
                //    {
                //        i++;
                //        if (i % 7 == 0)
                //        {
                //            Console.WriteLine(i);
                //        }
                //    }while (i >= 0 && i != j);
                //    Thread.Sleep(1000);
                //    do
                //    {
                //        i--;
                //        if (i % 7 == 0)
                //        {
                //            Console.WriteLine(i);
                //        }
                //    } while (i <= j && i != 0);
                //    Thread.Sleep(1000);
                //}

                //string[] test = new string[] { 
                //    "10/19/2014 19:48", 
                //    "10/19/2014 19:56", 
                //    "10/19/2013 19:48",
                //    "10/19/2011 19:48"
                //};

                //List<DateTime> testMax = new List<DateTime>();

                //for (int i = 0; i < 4; i++)
                //{
                //    testMax.Add(DateTime.Parse(test[i]));
                //}

                //int[] test = new int[]{15, 6, 54,78};
                //Console.WriteLine();

                #region dcstepping
                ////int i = 0;
                //int target = 187;
                //dcAction dcControl = new dcAction("COM4");
                //dcControl.Init();
                //dcControl.WritePWM(target);

                ////while (i<100000)
                ////{
                //    Console.WriteLine(dcControl.ReadLine());
                //    //Console.WriteLine(i++);
                ////    i++;
                ////}

                //dcControl.WritePWM(0);

                ////while (i<100000)
                ////{
                //    Console.WriteLine(dcControl.ReadLine());
                //    //Console.WriteLine(i++);
                ////    i++;
                ////}

                //Console.WriteLine(dcControl.IsOpen());
                //dcControl.Terminate();

                //Console.WriteLine(dcControl.IsOpen());
                #endregion
                # region sharpduino
                //// Arduino controlling
                //int PWMvalue = 1;

                //var arduino = new ArduinoUno("COM21");
                //while (!arduino.IsInitialized) ;
                //arduino.SetPinMode(ArduinoUnoPins.D11_PWM, PinModes.PWM);
                //Console.WriteLine("set pin 11 as PWM");

                //while (PWMvalue != 0)
                //{
                //    Console.WriteLine("please set PWM value in range 1-255...");
                //    bool parseInt = Int32.TryParse(Console.ReadLine(), out PWMvalue);

                //    if (!parseInt)
                //    {
                //        Console.WriteLine("your input is not string nor convertable number.");
                //        PWMvalue = 0;
                //    }

                //    //int[] aa = Enumerable.Range(1, 11).ToArray();
                //    //Array.Reverse(aa);

                //    //foreach (int i in aa)
                //    //{
                //    //    Console.WriteLine(i);
                //    //    arduino.SetPWM(ArduinoUnoPWMPins.D11_PWM, PWMvalue/i);
                //    //    Thread.Sleep(750);
                //    //}

                //    arduino.SetPWM(ArduinoUnoPWMPins.D11_PWM, PWMvalue);

                //    Console.WriteLine("set PWM = {0}", PWMvalue);
                //    Console.WriteLine("fill 0 to exit or set any number in range 1-255 to continue.");
                //}

                //arduino.SetPWM(ArduinoUnoPWMPins.D11_PWM, 0);
                //Console.WriteLine("set PWM = 0");
                //Console.WriteLine("disposing...");
                //arduino.Dispose();
                //Console.WriteLine("arduino disposed, press any key to terminate..");
                #endregion
                #region fundamental
                //Console.WriteLine("Thread Start/Stop/Join Sample");

                //Alpha oAlpha = new Alpha();

                //// Create the thread object, passing in the Alpha.Beta method
                //// via a ThreadStart delegate. This does not start the thread.
                //Thread oThread = new Thread(() => Console.WriteLine(oAlpha.Beta(77)));

                //// Start the thread
                //oThread.Start();

                //// Spin for a while waiting for the started thread to become
                //// alive:
                //while (!oThread.IsAlive) ;

                //// Put the Main thread to sleep for 1 millisecond to allow oThread
                //// to do some work:
                //Thread.Sleep(5);

                //// Request that oThread be stopped
                //oThread.Abort();

                //// Wait until oThread finishes. Join also has overloads
                //// that take a millisecond interval or a TimeSpan object.
                //oThread.Join();

                //Console.WriteLine();
                //Console.WriteLine("Alpha.Beta has finished");

                //try
                //{
                //    Console.WriteLine("Try to restart the Alpha.Beta thread");
                //    oThread.Start();
                //}
                //catch (ThreadStateException)
                //{
                //    Console.Write("ThreadStateException trying to restart Alpha.Beta. ");
                //    Console.WriteLine("Expected since aborted threads cannot be restarted.");
                //}

                //int i = new int();

                //Console.WriteLine(i);

                //// Create objects:
                //Employee E1 = new Employee("Mingda Pan", "mpan");

                //// Display results:
                //E1.printEmployee();

                //// Input the side:
                //Console.Write("Enter the side: ");
                //string sideString = Console.ReadLine();
                //double side = double.Parse(sideString);

                //// Compute areas:
                //Square s = new Square(side);
                //Cube c = new Cube(side);

                //// Display results:
                //Console.WriteLine("Area of a square = {0:F2}", s.Area);
                //Console.WriteLine("Area of a cube = {0:F2}", c.Area);

                //// Input the area:
                //Console.Write("Enter the area: ");
                //string areaString = Console.ReadLine();
                //double area = double.Parse(areaString);

                //// Compute sides:
                //s.Area = area;
                //c.Area = area;

                //// Display results:
                //Console.WriteLine("Side of a square = {0:F2}", s.side);
                //Console.WriteLine("Side of a cube = {0:F2}", c.side);

                //// get-set accessors
                //DerivedClass d1 = new DerivedClass();
                //d1.Name = "John";  // Derived class property
                //Console.WriteLine("Name in the derived class is: {0}", d1.Name);
                //((BaseClass)d1).Name = "Mary"; // Base class property
                //Console.WriteLine("Name in the base class is: {0}",
                //((BaseClass)d1).Name);   

                //// static vs non-static classes

                //testNormalClass normal = new testNormalClass();
                ////testSttClass sttClass = new testSttClass(); // cant do this
                //testSttClass.testSttInSttclass();
                //normal.testnoStt(); // can only call this
                ////normal.testStt(); // cant do this
                //testNormalClass.testStt(); // can do this too
                #endregion

                Console.ReadKey();



        }
    }
}
