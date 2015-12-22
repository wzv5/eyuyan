using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dotnet_lib
{
    [ClassInterface(ClassInterfaceType.AutoDispatch), ComVisible(true)]
    public class Class1
    {
        public Class1()
        {
            MessageBox.Show("Class1已创建", "C#中的信息框", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ~Class1()
        {
            MessageBox.Show("Class1已释放", "C#中的信息框", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int Test(string msg)
        {
            MessageBox.Show(msg, "C#中的信息框", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return msg.Length;
        }

        public int func()
        {
            return 42;
        }

        public int IntValue { get; set; }
    }
}
