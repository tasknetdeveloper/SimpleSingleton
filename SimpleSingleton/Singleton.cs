namespace SimpleSingleton
{
    public sealed class Singleton
    {
        private Singleton()
        {
            Console.WriteLine("This is single");
        }

        private static Singleton? source = null;
        private static readonly object tlock = new object();

        public static Singleton Source
        {
            get
            {

                lock (tlock)
                {
                    if (source == null)
                        source = new Singleton();

                    return source;
                }
            }
        }
    }
}
