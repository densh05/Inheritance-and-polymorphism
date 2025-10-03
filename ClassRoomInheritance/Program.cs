using System;
using System.Text;
using ClassRoomInheritance;

namespace ClassRoomInheritance
{
   

    class Pupil
    {
        

        public virtual void Study() { Console.WriteLine("Звичайний учень якось вчиться"); }
        public virtual void Read() { Console.WriteLine("Звичайний учень якось читає"); }
        public virtual void Write() { Console.WriteLine("Звичайний учень якось пише"); }
        public virtual void Relax() { Console.WriteLine("Звичайний учень якось відпочиває"); }
        
    }

    class ExcelentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Відмінний учень відмінно вчиться"); }
        public override void Read() { Console.WriteLine("Відмінний учень відмінно читає"); }
        public override void Write() { Console.WriteLine("Відмінний учень відмінно пише"); }
        public override void Relax() { Console.WriteLine("Відмінний учень відмінно відпочиває"); }
    }

    class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Хороший учень добре вчиться"); }
        public override void Read() { Console.WriteLine("Хороший учень добре читає"); }
        public override void Write() { Console.WriteLine("Хороший учень добре пише"); }
        public override void Relax() { Console.WriteLine("Хороший учень добре відпочиває"); }
    }

    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Поганий учень погано вчиться"); }
        public override void Read() { Console.WriteLine("Поганий учень погано читає"); }
        public override void Write() { Console.WriteLine("Поганий учень погано пише"); }
        public override void Relax() { Console.WriteLine("Поганий учень погано відпочиває"); }
    }
}

class ClassRoom
{
    private Pupil pupil1;
    private Pupil pupil2;
    private Pupil pupil3;
    private Pupil pupil4;

    public ClassRoom(Pupil p1,Pupil p2)
    {
        pupil1 = p1;
        pupil2 = p2;
        pupil3 = new Pupil();
        pupil4 = new Pupil();
    }

    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
        pupil1 = p1;
        pupil2 = p2;
        pupil3 = p3;
        pupil4 = new Pupil();
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
    {
        pupil1 = p1;
        pupil2 = p2;
        pupil3 = p3;
        pupil4 = p4;
    }

    public void ShowInfo()
    {
        Console.WriteLine("\nPupil 1:");
        pupil1.Study();  pupil1.Read(); pupil1.Write(); pupil1.Relax();

        Console.WriteLine("\nPupil 2:");
        pupil2.Study();  pupil2.Read(); pupil2.Write(); pupil2.Relax();

        Console.WriteLine("\nPupil 3:");
        pupil3.Study();  pupil3.Read(); pupil3.Write(); pupil3.Relax();

        Console.WriteLine("\nPupil 4:");
        pupil4.Study();  pupil4.Read(); pupil4.Write(); pupil4.Relax();
    }


}


    internal class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;


            ClassRoom classroom = new ClassRoom(new GoodPupil(),new BadPupil());

            classroom.ShowInfo();
        
        }
    }

