#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NumberParserExtended;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
#endregion

namespace NumberParserExtendedTest
{
    /// <summary>
    /// Tests for the Ocr Class
    /// </summary>
    [TestFixture, Description("Tests for Ocr")]
    public class OcrTest
    {
        #region Class Variables
        private Ocr _ocr;
        #endregion

        #region Setup/Teardown

        /// <summary>
        /// Code that is run before each test
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            //New instance of Ocr
            _ocr = new Ocr();
        }

        /// <summary>
        /// Code that is run after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            //TODO:  Put dispose in here for _ocr or delete this line
        }
        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Dump Result Method Test
        /// Documentation:  
        /// Method Signature:  void DumpResult(List&lt;tessnet2.Word&gt; result)
        /// </summary>
        [Test]
        public void DumpResultTest()
        {
            DateTime methodStartTime = DateTime.Now;
            
            //Parameters
            List<tessnet2.Word> result = new List<tessnet2.Word>();

            _ocr.DumpResult(result);

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("NumberParserExtended.Ocr.DumpResult Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// Do OCredit Normal Method Test
        /// Documentation   :  
        /// Method Signature:  List&lt;tessnet2.Word&gt; DoOCRNormal(Bitmap image, string lang)
        /// </summary>
        [Test]
        public void DoOCRNormalTest()
        {
            DateTime methodStartTime = DateTime.Now;
            List<tessnet2.Word> expected = new List<tessnet2.Word>();
            
            //Parameters
            Bitmap image = new Bitmap(2, 2);
            const string lang = "test";

            System.Reflection.MethodInfo method =
                typeof(Ocr).GetMethod("DoOCRNormal",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Ocr ocr = new Ocr();

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("NumberParserExtended.Ocr.DoOCRNormal Time Elapsed: {0}", methodDuration));
        }

        /// <summary>
        /// Do OCredit Multi Thred Method Test
        /// Documentation   :  
        /// Method Signature:  void DoOCRMultiThred(Bitmap image, string lang)
        /// </summary>
        [Test]
        public void DoOCRMultiThredTest()
        {
            DateTime methodStartTime = DateTime.Now;
            
            //Parameters
            Bitmap image = new Bitmap(2, 2);
            const string lang = "test";

            System.Reflection.MethodInfo method = typeof(Ocr).GetMethod("DoOCRMultiThred",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Ocr ocr = new Ocr();
            method.Invoke(ocr, new object[] { image, lang });

            TimeSpan methodDuration = DateTime.Now.Subtract(methodStartTime);
            Console.WriteLine(String.Format("NumberParserExtended.Ocr.DoOCRMultiThred Time Elapsed: {0}", methodDuration));
        }
        #endregion

        #endregion
    }
}
