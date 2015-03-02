#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NumberParserExtended;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
#endregion

namespace NumberParserExtendedTest
{

    /// <summary>
    /// Tests for the Program Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Program")]
    public class ProgramTest
    {
        #region Class Variables
        private Program _program;
        #endregion

        #region Setup/Teardown

        /// <summary>
        /// Code that is run before each test
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            //New instance of Program
            _program = new Program();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _program or delete this line
        }
        #endregion

        #region Method Tests

        /// <summary>
        /// Main Method Test
        /// Documentation   :  
        /// Method Signature:  void Main(string[] args)
        /// </summary>
        [Test]
        public void MainTest()
        {
            DateTime methodStartTime = DateTime.Now;
            
            //Parameters
            string[] args = new string[20];

            System.Reflection.MethodInfo method =
                typeof(Program).GetMethod("Main",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            method.Invoke(null, new object[] { args });

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("NumberParserExtended.Program.Main Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// Convert Text To Image Method Test
        /// Documentation:  
        /// Method Signature:  Bitmap ConvertTextToImage(string txt, string fontname, int fontsize, Color bgcolor, Color fcolor, int width, int Height)
        /// </summary>
        [Test]
        public void ConvertTextToImageTest()
        {
            DateTime methodStartTime = DateTime.Now;
            Bitmap expected = new Bitmap(2, 2);
            
            //Parameters
            const string txt = "test";
            const string fontname = "test";
            const int fontsize = 12;
            Color bgcolor = new Color();
            Color fcolor = new Color();
            const int width = 123;
            const int Height = 123;

            Bitmap results = Program.ConvertTextToImage(txt, fontname, fontsize, bgcolor, fcolor, width, Height);
            Assert.AreEqual(expected, results, "NumberParserExtended.Program.ConvertTextToImage method test failed");

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("NumberParserExtended.Program.ConvertTextToImage Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// Convert Image To Text Method Test
        /// Documentation   :  
        /// Method Signature:  void ConvertImageToText(Bitmap image)
        /// </summary>
        [Test]
        public void ConvertImageToTextTest()
        {
            DateTime methodStartTime = DateTime.Now;
            
            //Parameters
            Bitmap image = new Bitmap(2, 2);

            Program.ConvertImageToText(image);

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("NumberParserExtended.Program.ConvertImageToText Time Elapsed: {0}", methodDuration));
        }

        #endregion 
    }
}
