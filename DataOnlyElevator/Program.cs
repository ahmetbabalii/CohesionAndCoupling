
namespace DataOnlyElevatorTest
{
    internal class Program
    {

        private static readonly DataOnlyElevator _elevator = new DataOnlyElevator();

        static void Main(string[] args)
        {
            writeElevatorState();
            _elevator.doorOpen = true;
            _elevator.doorOpen = false;
            _elevator.currentFloor--; // 0. katta iken aşağıya inmeye çalıştı. Normalde iş kuralı eklenerek engellenmesi gerekiyor.
            _elevator.currentFloor++; // Kapı Açık olduğunda katlar arasında asansörün ilerleyemiyor olması gerekiyor.
            _elevator.currentFloor = 6; // Binada sadece 5 kat var fakat 6. kata gitmek istiyor.
            writeElevatorState();

            /*
                * Burada DataOnlyElevator sadece veriyi sağlıyor yani davranışa bağlı olarak bir duruş sergilemiyor.
                * Veri ile ilgili birliktelik yüksektir fakat davranışsal birliktelikten bahsetmek mümkün değildir.
                * Özetle buradaki tüm davranış modelini süreçle ilgili olarak rastgele olarak yazmış olduk (Herganbir iş kuralı bulunmuyor). 
                * Tüm sorumluluğu program.cs üzerinde bulunuyor. 
                * Davranışsal bir duruş sergilemediği için farklı bir senaryo oluşması veya bir gereklilik eklenmesi -
                    durumunda bu şekilde tasarlanmış yapılarda her yer etkilenecektir. -
                    Fakat daha da kötüsü etkilenen yerin tespiti noktasında da zorluklar ortaya -
                    çıkacaktır ve sorunun kaynağının tespiti için uzun debuglara ihtiyaç olacaktır.                    
            */
        }

        private static void writeElevatorState()
        {
            string doorStatus = _elevator.doorOpen ? "açık" : "kapalı";
            Console.WriteLine($"Asansör {_elevator.currentFloor}. katta ve kapı {doorStatus}");
        }
    }
}
