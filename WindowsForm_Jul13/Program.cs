using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Jul13
{
    static class Program
    {

        // 1. Declare a form
        public static HelloWorldForm helloWorldForm;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // pre // 1. Declare a form
            //HelloWorldForm helloWorldForm;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 2. Instantiate a form
            helloWorldForm = new HelloWorldForm();

            // 3. pass a reference to the application
            Application.Run(helloWorldForm);
        }
    }
}
