using System;
using System.Windows.Forms;

class Program : Form
{
    public void MouseHandler(object sender, MouseEventArgs e)
    {
        Console.WriteLine("Sender : " + ((Form)sender).Text);
        Console.WriteLine("Sender : " + ((Form)sender).Name);
        Console.WriteLine($"X:{e.X}, Y:{e.Y}");
        Console.WriteLine($"Button:{e.Button}, Click:{e.Clicks}");
    }

    public Program(String title)
    {
        this.Text = title;
        this.Name = "원폼";
        //MouseDown 이벤트 처리기 등록
        this.MouseDown += new MouseEventHandler(MouseHandler);
    }

    static void Main(string[] args)
    {
        Application.Run(new Program("마우스 이벤트 예제"));
    }
}