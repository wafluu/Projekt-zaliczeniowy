using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GambluUsume
{
    public static class Class1
    {
        public static void CloseIfOpen<T>() where T : Form
        {
            Form f = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (f != null)
            {
                f.Close();
            }
        }

        public static void CloseIfOpen(params Type[] formTypes)
        {
            foreach (Type t in formTypes)
            {
                Form f = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.GetType() == t);

                if (f != null)
                {
                    f.Close();
                }
            }
        }
    }
}
