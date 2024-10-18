using System;

namespace laboratory
{
    class Flask
    {
        private bool investigated;

        private void Sent()
        {
            Console.WriteLine("Иследуется...");
            investigated = true;
            Console.WriteLine("Иследована!");
        }

        public virtual void released()
        {
            if (!investigated)
            {
                Console.WriteLine("Не иследована");
                Sent();
            }

            Console.WriteLine("отправлена для подведения результатов");
            investigated = false;
        }
    }

    class Peerage : Flask
    {
        public override void released()
        {
            base.released();
            Console.WriteLine("отправлена на дальнейший анализ");
        }
    }

    class program
    {
        public static void Main()
        {
            Flask flask = new Flask();
            Peerage peerage = new Peerage();
            peerage.released();
        }
    }
}
