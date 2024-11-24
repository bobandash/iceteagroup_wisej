using System;
using Wisej.Web;

namespace WisejWebApplication3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            /*Form window = new Form();
            window.Show();*/
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}