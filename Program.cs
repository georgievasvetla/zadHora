using System.Reflection.Metadata;

namespace Horazad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Hora> hora=new List<Hora>();
                int n = int.Parse(Console.ReadLine());
                Hora h;
                for(int i=0;i<n;i++)
                {
                    var danni = Console.ReadLine().Split();
                    h = new Hora(danni[0], int.Parse(danni[1]), double.Parse(danni[2]), danni[3]);
                    hora.Add(h);
                }

            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}