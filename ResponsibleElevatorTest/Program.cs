
namespace ResponsibleElevatorTest
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            Elevator elevator = new ResponsibleElevator();
            elevator.openDoor(); 
            elevator.go(Floors.FIFTH);

            elevator.openDoor();
            elevator.go(Floors.FIRST);
            elevator.go(Floors.FIFTH);

            /*
             
                Asansörün yukarı veya aşağı yönlü hareketi sadece metot seviyesine indirgenmiştir.
                İstemci herşeyi arayüz (interface) ile edibiliyor hale getirildi.
                Bağımlılık (coupling) sadece metot seviyesine indirgendi.
                Gidilebicek katlar sınırlandırıldı. Kural setleri eklendi. Tüm hareketler enum yapısıyla basitleştirildi
                Burada ayrıca bir state yönetimi kurgulandı.
                Elevator ile Floor arasında bilgi alışverisi yok, sadece interface üzerinden bir bağımlılık söz konusu

             */
        }
    }
}