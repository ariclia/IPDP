using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void Print(string message)
        {
            MessageBox.Show(message);
        }

    }
}
